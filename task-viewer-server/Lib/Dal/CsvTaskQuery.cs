using System.Collections.Generic;
namespace Lib.Dal
{
    public class CsvTaskQuery : ITaskQuery
    {
        private Config _taskConfig;
        private List<Task> _tasks;
        private IDataExporter<List<Task>> _dataExporter;

        
        public CsvTaskQuery(Config config)
        {
            _tasks = new List<Task>();
            _taskConfig = config;
            _dataExporter = new CsvDataExporter<List<Task>>();
        }
        
        public List<Task> GetTasks(){
            if(_tasks.Count == 0)
                _tasks = GetAllTasks();
            return _tasks;
        }

        public void AddTask(Task task){
            _tasks.Add(task);
        }

        public Task GetTask(int taskId){
            Task task = _tasks.FirstOrDefault(task => task.Id == taskId.Id);
            return task;
        }

        private List<Task> GetAllTasks(){
            _tasks = _dataExporter.Export(_taskConfig.TasksCsvPath);
            return _tasks;
        }
    }
}