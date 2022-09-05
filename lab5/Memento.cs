using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    internal interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }

    class Originator
    {
        private string _state;

        public Originator(string state)
        {
            this._state = state;
        }

        public void ChangeText(string text)
        {
            _state = text;
        }

        public string GetData()
        {
            return _state;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        public void Restore(IMemento memento)
        {
            if (memento is ConcreteMemento)
            {
                this._state = memento.GetState();
            }
            else
            {
                MessageBox.Show("Unknown memento class " + memento.ToString());
            }
        }
    }

    class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        public string GetState()
        {
            return this._state;
        }

        public string GetName()
        {
            return $"{this._date} / ({this._state}";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }

    class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private Originator _originator = null;

        public Caretaker(Originator originator)
        {
            this._originator = originator;
        }

        public void Backup()
        {
            this._mementos.Add(this._originator.Save());
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            try
            {
                this._originator.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }
    }
}
