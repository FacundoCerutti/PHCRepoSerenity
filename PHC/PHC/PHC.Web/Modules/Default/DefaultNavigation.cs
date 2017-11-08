using Serenity.Navigation;
using MyPages = PHC.Default.Pages;

[assembly: NavigationLink(int.MaxValue, "Default/Departamento", typeof(MyPages.DepartamentoController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Empleado", typeof(MyPages.EmpleadoController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Historial Empleado", typeof(MyPages.HistorialEmpleadoController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Nivel", typeof(MyPages.NivelController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Puesto", typeof(MyPages.PuestoController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Puesto Tarea", typeof(MyPages.PuestoTareaController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Requerimiento", typeof(MyPages.RequerimientoController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Requerimiento Puesto", typeof(MyPages.RequerimientoPuestoController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Usuario", typeof(MyPages.UsuarioController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Tarea", typeof(MyPages.TareaController), icon: null)]