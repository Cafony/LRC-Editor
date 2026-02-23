using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LRC_Editor
{
    internal class UndoManager
    {
        private RichTextBox _richTextBox;
        private Stack<string> _undoStack = new Stack<string>();
        private Stack<string> _redoStack = new Stack<string>();
        private bool _internalChange = false;

        public UndoManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
            _richTextBox.TextChanged += RichTextBox_TextChanged;
            SaveState(); // initial state
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_internalChange)
                return;

            SaveState();
            _redoStack.Clear();
        }

        private void SaveState()
        {
            _undoStack.Push(_richTextBox.Text);
        }

        public void Undo()
        {
            if (_undoStack.Count > 1)
            {
                _internalChange = true;

                string current = _undoStack.Pop();
                _redoStack.Push(current);
                _richTextBox.Text = _undoStack.Peek();

                _internalChange = false;
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                _internalChange = true;

                string next = _redoStack.Pop();
                _undoStack.Push(next);
                _richTextBox.Text = next;

                _internalChange = false;
            }
        }

        public void ClearHistory()
        {
            _undoStack.Clear();
            _redoStack.Clear();
            SaveState();
        }

    }
}
