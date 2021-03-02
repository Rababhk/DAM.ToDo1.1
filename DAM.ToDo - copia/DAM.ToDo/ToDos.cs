using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.ToDo
{
    public class ToDos
    {
        private List<toDo> lst;
        public ToDos()
        {
            lst = new List<toDo>();
        }

    public toDo[] GetPending()
    {
        var pending = lst.FindAll(t => !t.Done.HasValue);
        return pending.ToArray();
    }
    public toDo[] done()
    {
        var done = lst.FindAll(t => !t.Done.HasValue);
        return done.ToArray();
    }
    public toDo Add(string task)
    {
        var t = new toDo(task);
        lst.Add(t);
        return t;
    }
    public bool remove(toDo t)
        {
            return lst.Remove(t);

        }
    public void Do(toDo t)
        {
            if (!t.Done.HasValue)
            {
                t.Done = DateTime.Now;
            }
        }
    public void unDo(toDo t)
    {
        if (t.Done.HasValue)
        {
            t.Done = null;
        }
        }
    }

}
