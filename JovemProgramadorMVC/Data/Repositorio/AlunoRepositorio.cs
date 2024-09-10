using JovemProgramadorMVC.Data.Repositorio.Interface;
using JovemProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramadorMVC.Data.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio

    {

        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)

        {

            _bancoContexto = bancoContexto;

        }

        public List<Aluno> BuscarAlunos()
        {

            return _bancoContexto.Aluno.ToList();

        }

       //03-09
        public void InserirAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }

        //05-09
        public Aluno BuscarId(int Id)
        {
            return _bancoContexto.Aluno.FirstOrDefault(x => x.Id == Id);    
        }

        public void EditarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Update(aluno);
            _bancoContexto.SaveChanges();
        }

        public void Excluir(Aluno aluno)
        {
            _bancoContexto.Remove(aluno);
            _bancoContexto.SaveChanges();
        }
    }

}
