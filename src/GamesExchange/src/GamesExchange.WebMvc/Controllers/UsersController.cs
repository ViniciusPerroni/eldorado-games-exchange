using GamesExchange.Application.lib;
using GamesExchange.Model.Identification;
using GamesExchange.WebMvc.Models;

using Microsoft.AspNetCore.Mvc;

using User = GamesExchange.Application.Identification.User;
using Person = GamesExchange.Application.Identification.Person;

namespace GamesExchange.WebMvc.Controllers
{
    public class UsersController : Controller
    {
        private readonly User.List.IUseCase listUseCase;
        private readonly User.Create.IUseCase createUseCase;
        private readonly User.Edit.IUseCase editUseCase;
        private readonly User.Delete.IUseCase deleteUseCase;
        private readonly User.GetById.IUseCase getByIdUseCase;
        private readonly Person.ListAllToDictionary.IUseCase personListAllToDictionaryUseCase;

        public UsersController(User.List.IUseCase listUseCase, User.Create.IUseCase createUseCase, User.Edit.IUseCase editUseCase,
            User.Delete.IUseCase deleteUseCase, User.GetById.IUseCase getByIdUseCase, 
            Person.ListAllToDictionary.IUseCase personListAllToDictionaryUseCase)
        {
            this.listUseCase = listUseCase;
            this.createUseCase = createUseCase;
            this.editUseCase = editUseCase;
            this.deleteUseCase = deleteUseCase;
            this.getByIdUseCase = getByIdUseCase;
            this.personListAllToDictionaryUseCase = personListAllToDictionaryUseCase;
        }

        public async Task<IActionResult> Index(UserFilter? filter, PageSummary? summary)
        {
            summary.PageNumber = summary.PageNumber == 0 ? 1 : summary.PageNumber;
            summary.PageSize = summary.PageSize == 0 ? 10 : summary.PageSize;

            var input = new User.List.Input { Filter = filter, Summary = summary };

            var result = await listUseCase.Execute(input);

            var pagination = new PaginationViewModel
            {
                Summary = result.Summary,
                Url = Url.Action("Index") + filter.ToQueryString()
            };

            var viewModel = new UserListViewModel
            {
                Data = result.Data,
                Filter = filter,
                Pagination = pagination
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Create()
        {
            var viewModel = new UserFormViewModel();
            await LoadPeople(viewModel);

            return View("Form", viewModel);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var viewModel = new UserFormViewModel();
            await LoadPeople(viewModel);

            var result = await getByIdUseCase.Execute(new User.GetById.Input { Id = id });

            viewModel.Id = id;
            viewModel.PersonId = result.Data.PersonId;
            viewModel.Username = result.Data.Username;
            viewModel.Active = result.Data.Active;
            viewModel.Role = result.Data.Role;

            return View("Form", viewModel);
        }

        private async Task LoadPeople(UserFormViewModel viewModel)
        {
            var result = await personListAllToDictionaryUseCase.Execute(new Person.ListAllToDictionary.Input());
            viewModel.People = result.Data;
        }

        [HttpPost]
        public async Task<IActionResult> Save(UserFormViewModel viewModel)
        {
            if (viewModel.Id == 0)
            {
                var input = new User.Create.Input
                {
                    PersonId = viewModel.PersonId,
                    Username = viewModel.Username,
                    Password = viewModel.Password,
                    Active = viewModel.Active,
                    Role = viewModel.Role
                };

                _ = await createUseCase.Execute(input);
            }
            else
            {
                var input = new User.Edit.Input
                {
                    Id = viewModel.Id,
                    PersonId = viewModel.PersonId,
                    Username = viewModel.Username,
                    Password = viewModel.Password,
                    Active = viewModel.Active,
                    Role = viewModel.Role
                };

                _ = await editUseCase.Execute(input);
            }

            return RedirectToAction("Index");
        }
    }
}
