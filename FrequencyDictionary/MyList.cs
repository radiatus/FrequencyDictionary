using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrequencyDictionary
{
    class MyNode
    {
        public string word;
        public int wordCount;
        public MyNode next;
       
        public MyNode(string word, int wordCount, MyNode next)
        {
            this.word = word;
            this.wordCount = wordCount;
            this.next = next;
        }
    }

    class MyList
    {
        public MyNode head; // голова списка
        public int count; // число элементов

        public MyList() // Конструктор
        {
            head = null;
            count = 0;
        }
        public void Add(string word, int count) // Add
        {
            MyNode p = new MyNode(word, count, head);
            head = p;
            this.count++;
        }


        public void PrinterDgr(DataGridView dgr) // Вывод списка
        {
            dgr.RowCount = count;
            MyNode p = head;
            int i = 0;
            do
            {
                dgr[0, i].Value = p.word;
                dgr[1, i].Value = p.wordCount;
                p = p.next;
                i++;
            }
            while (p != null);
            i = 0;
        }
        

        public bool FindNode(string val)// Есть ли узел в листе?
        {
            MyNode p = head;
            while ((p != null))
            {
                if(p.word == val)
                    return true;
                p = p.next;
            }
            return false;
        }

        public MyNode FindByNumber(int num)
        {
            MyNode p = head;
            for (int i = 0; i < num - 1; i++)
                if (i < count)
                    p = p.next;
                else
                {
                    break;
                }
            return p;
        }

        public void Delete(int index)
        {
            if (index != 0)
            {
                MyNode p = head;
                for (int i = 0; i < index - 1; i++)
                    p = p.next;
                if (p.next != null)
                    p.next = p.next.next;
            }
            else
                head = head.next;
            count--;
        }
    }
}
