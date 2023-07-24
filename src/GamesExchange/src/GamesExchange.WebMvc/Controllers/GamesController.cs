using GamesExchange.Application.lib;
using GamesExchange.Model.Games;
using Game = GamesExchange.Application.Games.Game;

using Microsoft.AspNetCore.Mvc;
using GamesExchange.WebMvc.Models;
using GamesExchange.Model.Identification;

namespace GamesExchange.WebMvc.Controllers
{
    public class GamesController : Controller
    {
        private readonly Game.List.IUseCase listUseCase;
        private readonly Game.Create.IUseCase createUseCase;
        private readonly Game.Edit.IUseCase editUseCase;
        private readonly Game.Delete.IUseCase deleteUseCase;
        private readonly Game.GetById.IUseCase getByIdUseCase;

        public GamesController(Game.List.IUseCase listUseCase, Game.Create.IUseCase createUseCase, Game.Edit.IUseCase editUseCase, 
            Game.Delete.IUseCase deleteUseCase, Game.GetById.IUseCase getByIdUseCase)
        {
            this.listUseCase = listUseCase;
            this.createUseCase = createUseCase;
            this.editUseCase = editUseCase;
            this.deleteUseCase = deleteUseCase;
            this.getByIdUseCase = getByIdUseCase;
        }

        public async Task<IActionResult> Index(GameFilter? filter, PageSummary? summary)
        {
            summary.PageNumber = summary.PageNumber == 0 ? 1 : summary.PageNumber;
            summary.PageSize = summary.PageSize == 0 ? 10 : summary.PageSize;

            var input = new Game.List.Input { Filter = filter, Summary = summary };

            var result = await listUseCase.Execute(input);
            
            var pagination = new PaginationViewModel
            {
                Summary = result.Summary,
                Url = Url.Action("Index") + filter.ToQueryString()
            };

            var viewModel = new GameListViewModel
            {
                Data = result.Data,
                Filter = filter,
                Pagination = pagination
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Create()
        {
            var viewModel = new GameFormViewModel();

            return View("Form", viewModel);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var viewModel = new GameFormViewModel();
            var result = await getByIdUseCase.Execute(new Game.GetById.Input { Id = id });

            viewModel.Id = id;
            viewModel.Name = result.Data.Name;
            viewModel.Description = result.Data.Description;
            viewModel.Console = result.Data.Console;
            viewModel.Studio = result.Data.Studio;
            viewModel.OwnerId = result.Data.OwnerId;
            viewModel.Price = result.Data.Price;

            return View("Form", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Save(GameFormViewModel viewModel)
        {
            if (viewModel.Id == 0)
            {
                var input = new Game.Create.Input
                {
                    Name = viewModel.Name,
                    Description = viewModel.Description,
                    Console = viewModel.Console,
                    Studio = viewModel.Studio,
                    OwnerId = viewModel.OwnerId,
                    Price = viewModel.Price
                };

                _ = await createUseCase.Execute(input);
            }
            else
            {
                var input = new Game.Edit.Input
                {
                    Id = viewModel.Id,
                    Name = viewModel.Name,
                    Description = viewModel.Description,
                    Console = viewModel.Console,
                    Studio = viewModel.Studio,
                    OwnerId = viewModel.OwnerId,
                    Price = viewModel.Price
                };

                _ = await editUseCase.Execute(input);
            }

            return RedirectToAction("Index");
        }
    }
}
