using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Collection<T> : IAdd<T>, IRemove<T>, IEqualityComparer<T> where T : Student
    {
        //this collection is like a "Queue"
        private T[] studentlist = new T[100];
        private int index = 0;

        public void SetStudent(int i, T s)
        {
            studentlist[i] = s;
        }

        public T GetStudent(int i)
        {
            if(studentlist[i] == null)
            {
                return null;
            }
            return studentlist[i];
        }

        public void SwapStudents(int index1, int index2)
        {
            T aux;
            aux = studentlist[index1];
            studentlist[index1] = studentlist[index2];
            studentlist[index2] = aux;
        }

        public void Add(T item)
        {
            if(index < 100)
            {
                studentlist[index++] = item;
            }
            else
            {
                throw new InvalidOperationException("This collection is full!");
            }
        }

        public T Remove()
        {
            index--;
            if (index >= 0)
            {
                T aux = studentlist[index];
                studentlist[index] = null;
                return aux;
            }
            else
            {
                index = 0;
                throw new InvalidOperationException("This collection is empty!");
            }
        }

        public bool Equals(T x, T y)
        {
            if(x.name.Equals(y.name) && (x.age == y.age))
            {
                return true;
            }
            return false;
        }

        public int GetHashCode([DisallowNull] T obj)
        {
            return obj.GetHashCode();
        }

        public T[] GetAll()
        {
            return studentlist;
        }
    }
}
