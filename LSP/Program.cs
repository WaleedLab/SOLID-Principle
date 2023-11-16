using LSP.v2;

CEO ceo = new CEO();
ProjektManager pm = new ProjektManager();
Programmer programmer = new Programmer();

programmer.GetSalary();
ceo.Fire(programmer);
pm.Fire(programmer);