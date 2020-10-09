using System.Threading.Tasks;
namespace Lib.Dal
{
    public interface ITaskQuery
    {
         public List<Task> GetTasks();
         public void AddTask(Task task);
         public Task GetTask(int taskId);
    }
}