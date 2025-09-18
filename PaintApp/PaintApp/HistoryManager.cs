using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    internal class HistoryManager
    {
        Stack<Bitmap> undo_stack = new Stack<Bitmap>();
        Stack<Bitmap> redo_stack = new Stack<Bitmap>();        
        int undo_limit = int.MaxValue;


         public void UpdateStatus(Bitmap bitmap)
        {
            // zwraca object wiec trzeba rzutowac
            //undo_stack.Push((Bitmap)bitmap.Clone());
            //redo_stack.Clear();


            if (undo_stack.Count >= undo_limit)
            {
                undo_stack = new Stack<Bitmap>(undo_stack.Reverse().Skip(1));
            }

            // dodaje aktualny stan
            undo_stack.Push((Bitmap)bitmap.Clone());
            redo_stack.Clear();
        }

        public Bitmap Undo(Bitmap bitmap)
        {
            if (undo_stack.Count > 0)
            {
                redo_stack.Push((Bitmap)bitmap.Clone());
                return undo_stack.Pop();
            }

            return bitmap;
        }

        public Bitmap Redo(Bitmap bitmap)
        {
            if (redo_stack.Count > 0)
            {
                undo_stack.Push((Bitmap)bitmap.Clone());
                return redo_stack.Pop();
            }
            return bitmap;
        }

        public void Clear()
        {
            undo_stack.Clear();
            redo_stack.Clear();
        }
    }
}
