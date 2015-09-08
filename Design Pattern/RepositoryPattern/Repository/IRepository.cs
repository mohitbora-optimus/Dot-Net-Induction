using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IRepository<T> where T:class
    {
     //   IEnumerator<T> List { get; }

         void Add(T entity);
         void Delete(int StateId);
       //  void Update(T entity);
      //   T FindByID(int Id);
    }

    public class StateService: IRepository<State>
    {
        private StateConnectionString  _stateDBContext;

        public void Add(State newState)
        {
            _stateDBContext = new StateConnectionString();
            _stateDBContext.States.Add(newState);
            _stateDBContext.SaveChanges();
        }

        public void Delete(int StateId)
        {
            _stateDBContext = new StateConnectionString();
            State toBeDeleted = _stateDBContext.States.Find(StateId);
            _stateDBContext.States.Remove(toBeDeleted);
            _stateDBContext.SaveChanges();
        }

        public void update(State toBeUpdated)
        {
            _stateDBContext = new StateConnectionString();
            _stateDBContext.Entry(toBeUpdated).State = System.Data.Entity.EntityState.Modified;
            _stateDBContext.SaveChanges();
        }

        public State FindById(int StateId)
        {
            _stateDBContext = new StateConnectionString();
            return _stateDBContext.States.Find(StateId);
        }
    }
}
