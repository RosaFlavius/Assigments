using Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Collection<T> : IAdd<T>, IRemove<T> where T : Student
    {
        private T[] studentlist = new T[1000];
        private int index = 0;

        public void SetStudent(int i, T s)
        {
            studentlist[i] = s;
        }

        public T GetStudent(int i)
        {
            if (studentlist[i] == null)
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
            if (index < 1000)
            {
                studentlist[index] = item;
                index++;
            }
            else
            {
                throw new InvalidOperationException("Collection is full!");
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
                throw new InvalidOperationException("Collection is empty!");
            }
        }


        public T[] GetAll()
        {
            return studentlist;
        }
    }
}
