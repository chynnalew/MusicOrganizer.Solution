using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordTests : IDisposable
  {
    public void Dispose()
    {
      Record.ClearAll();
    }

    [TestMethod]
    public void RecordConstructor_CreatesInstanceOfRecord_Record()
    {
      Record newRecord = new Record("test", "test");
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }
    [TestMethod]
    public void RecordConstructor_TakesRecordNameAsAProperty_True()
    {
      Record testRecord = new Record("album name", "test");
      Assert.AreEqual(testRecord.RecordName, "album name");
    }
    [TestMethod]
    public void ArtistConstructor_ReturnsArtistName_Artist()
    {
      Record newArtist = new Record("album name", "artist name");
      Assert.AreEqual(newArtist.ArtistName, "artist name");
    }
    [TestMethod]
    public void List_ReadsEmptyList_True()
    {
      List<Record> emptyList = new List<Record>{};
      List<Record> testList = Record.GetList();
      CollectionAssert.AreEqual(emptyList,testList);
    }
  }
}