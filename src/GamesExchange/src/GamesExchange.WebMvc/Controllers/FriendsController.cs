using GamesExchange.Application.lib;
using GamesExchange.Model.Games;
using GamesExchange.Model.Identification;
using GamesExchange.WebMvc.Models;

using Microsoft.AspNetCore.Mvc;

using Person = GamesExchange.Application.Identification.Person;

namespace GamesExchange.WebMvc.Controllers
{
    public class FriendsController : Controller
    {
        private readonly Person.List.IUseCase listUseCase;
        private readonly Person.Create.IUseCase createUseCase;
        private readonly Person.Edit.IUseCase editUseCase;
        private readonly Person.Delete.IUseCase deleteUseCase;
        private readonly Person.GetById.IUseCase getByIdUseCase;

        public FriendsController(Person.List.IUseCase listUseCase, Person.Create.IUseCase createUseCase, Person.Edit.IUseCase editUseCase, 
            Person.Delete.IUseCase deleteUseCase, Person.GetById.IUseCase getByIdUseCase)
        {
            this.listUseCase = listUseCase;
            this.createUseCase = createUseCase;
            this.editUseCase = editUseCase;
            this.deleteUseCase = deleteUseCase;
            this.getByIdUseCase = getByIdUseCase;
        }

        public async Task<IActionResult> Index(PersonFilter? filter, PageSummary? summary)
        {
            summary.PageNumber = summary.PageNumber == 0 ? 1 : summary.PageNumber;
            summary.PageSize = summary.PageSize == 0 ? 10 : summary.PageSize;

            var input = new Person.List.Input { Filter = filter, Summary = summary };

            var result = await listUseCase.Execute(input);

            var pagination = new PaginationViewModel
            {
                Summary = result.Summary,
                Url = Url.Action("Index") + filter.ToQueryString()
            };

            var viewModel = new FriendsListViewModel
            {
                Data = result.Data,
                Filter = filter,
                Pagination = pagination
            };

            return View(viewModel);
        }

        public IActionResult Create()
        {
            var viewModel = new FriendsFormViewModel();

            return View("Form", viewModel);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var viewModel = new FriendsFormViewModel();

            var result = await getByIdUseCase.Execute(new Person.GetById.Input { Id = id });

            viewModel.Id = id;
            viewModel.FirstName = result.Data.FirstName;
            viewModel.LastName = result.Data.LastName;
            viewModel.Email = result.Data.Email;
            viewModel.CellNumber = result.Data.CellNumber;
            viewModel.PhoneNumber = result.Data.PhoneNumber;

            return View("Form", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Save(FriendsFormViewModel viewModel)
        {
            if (viewModel.Id == 0)
            {
                var input = new Person.Create.Input
                {
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    Email = viewModel.Email,
                    CellNumber = viewModel.CellNumber,
                    PhoneNumber = viewModel.PhoneNumber
                };

                _ = await createUseCase.Execute(input);
            }
            else
            {
                var input = new Person.Edit.Input
                {
                    Id = viewModel.Id,
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    Email = viewModel.Email,
                    CellNumber = viewModel.CellNumber,
                    PhoneNumber = viewModel.PhoneNumber
                };

                _ = await editUseCase.Execute(input);
            }

           return RedirectToAction("Index");
        }
    }
}
