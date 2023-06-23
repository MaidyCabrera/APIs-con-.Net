using webapi;
using webapi.Models;

public class TareasService : ItareasService
{
    TareasContext context;

    public TareasService(TareasContext dbcontext)
    {
        context = dbcontext;
    }

    public IEnumerable<Tarea> Get()
    {
        return context.Tareas;
    }
}

public interface ItareasService
{
    IEnumerable<Tarea> Get();
    
}

