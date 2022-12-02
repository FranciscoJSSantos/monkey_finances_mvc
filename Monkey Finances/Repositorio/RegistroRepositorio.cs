using Microsoft.AspNetCore.Mvc;
using Monkey_Finances.Data;
using Monkey_Finances.Models;

namespace Monkey_Finances.Repositorio
{
    public class RegistroRepositorio : IRegistroRepositorio
    {
        private readonly BancoContext _bancoContext;

        public RegistroRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public RegistroModel ListarPorId(int id)
        {
            return _bancoContext.Registro.FirstOrDefault(x => x.Id == id);
        }

        public List<RegistroModel> BuscarTodos()
        {
            return _bancoContext.Registro.ToList();
        }

        public RegistroModel Adicionar(RegistroModel registro)
        {
            _bancoContext.Registro.Add(registro);
            _bancoContext.SaveChanges();

            return registro;
        }

        public RegistroModel Atualizar(RegistroModel registro)
        {
            RegistroModel registroDB = ListarPorId(registro.Id);

            if (registroDB == null) throw new System.Exception("Houve um erro na atualização");

            registroDB.Name = registro.Name;
            registroDB.Valor = registro.Valor;
            registroDB.Tipo = registro.Tipo;

            _bancoContext.Update(registroDB);
            _bancoContext.SaveChanges();

            return registroDB;
         
        }

        public bool Apagar(int id)
        {
            RegistroModel registroDB = ListarPorId(id);

            if (registroDB == null) throw new System.Exception("Houve um erro na hora de apagar");

            _bancoContext.Registro.Remove(registroDB);
            _bancoContext.SaveChanges();

            return true;
        }


    }
}
