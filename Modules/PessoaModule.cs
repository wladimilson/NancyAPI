using Nancy;
using Nancy.ModelBinding;
using NancyAPI.Models;
using NancyAPI.Repositories;

namespace NancyAPI.Module
{
    public class PessoaModule: NancyModule
    {
        public readonly PessoaRepository repository;
        public PessoaModule()
        {
            repository = new PessoaRepository();

            Get("/pessoa/", _ => repository.GetAll());
            Get("/pessoa/{id}", args => repository.Get(args.id));
            Post("/pessoa/", args => {
                var pessoa = this.Bind<Pessoa>();
                
                repository.Add(pessoa);

                return pessoa;
            });
            Put("/pessoa/{id}", args => {
                var pessoa = this.Bind<Pessoa>();
                
                pessoa.Id = args.id;

                repository.Edit(pessoa);

                return pessoa;
            });
        }
    }
}