using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Dantom", "Nunes");
Pessoa p2 = new Pessoa("Eduardo", "Neves");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();








// p1.Idade = 24;
// p1.Apresentar ();