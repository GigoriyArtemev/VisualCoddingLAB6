using System.Collections.ObjectModel;

namespace VisualCoddingLAB6.Models
{
    interface INoteStateHandler
    {
        public void AddNewNoteToFile(string Date, string Name, string Text, int ID);
        public void GetAllNotes(string Date, ObservableCollection<NoteState> ListForWriting);
    }
}