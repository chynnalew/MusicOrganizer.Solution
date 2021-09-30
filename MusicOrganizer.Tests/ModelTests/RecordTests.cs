using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordTests
  {
    [TestMethod]
    public void RecordConstructor_CreatesInstanceOfRecord_Record()
    {
      Record newRecord = new Record("test");
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }
    [TestMethod]
    public void RecordConstructor_TakesRecordNameAsAProperty_True()
    {
      Record testRecord = new Record("album name");
      Assert.AreEqual(testRecord.RecordName, "album name");
    }
  }
}