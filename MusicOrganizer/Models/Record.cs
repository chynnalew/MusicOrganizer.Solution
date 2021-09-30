using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record 
  {
    public string RecordName { get; set; }
    public string ArtistName { get; set; }
    public int Id { get; }
    private static int _counter = 0;

    private static List<Record> _recordList = new List<Record> {};

    public Record (string recordName, string artistName)
    {
      RecordName = recordName;
      ArtistName = artistName;
      Id = _counter++;
      _recordList.Add(this);
    }

    public static List<Record> GetList()
    {
      return _recordList;
    }
    
    public static void ClearAll()
    {
      _recordList.Clear();
      _counter = 0;
    }

    public static Record FindRecord(int ID)
    {
      return _recordList.Find(x => x.Id ==ID);
      
    }
    
    public static void DeleteRecord(int ID)
    {
      var recordToRemove = _recordList.Find(x => x.Id ==ID);
      _recordList.Remove(recordToRemove);
    }
  }
}