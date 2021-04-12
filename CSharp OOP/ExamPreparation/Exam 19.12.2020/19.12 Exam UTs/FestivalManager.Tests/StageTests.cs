// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    
    using NUnit.Framework;
	using System;
	

    [TestFixture]
	public class StageTests
    {
		private Stage stage;
		private Song song2;
		private Song song;
		private Performer perfomer;
		private Performer perf;
		private Performer perf2;
		private Performer perf3;
		private Performer perf4;

		[SetUp]
		public void Setup()
        {
			stage = new Stage();
			song2 = new Song("Moq", new TimeSpan(0, 3, 45));
			perf = new Performer("M", "J", 12);
			perf2 = null;
			perf3 = new Performer("L", "J", 55);
			perf4 = new Performer("J", "D", 34);
			perfomer = new Performer("Enrique", "Manqka", 25);
			song = new Song("Velikanska", new TimeSpan(0, 02, 45));
		}

		[Test]
	    public void ADDIfPerformerNUll_ANE()
	    {
			Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(perf2));
		}

		[Test]
		public void ADDIfPerformeAgeLess18_AE()
		{
			Assert.Throws<ArgumentException>(() => stage.AddPerformer(perf));
		}

		[Test]
		public void ADDAddsPerf()
		{
			Assert.AreEqual(0, stage.Performers.Count);
			stage.AddPerformer(perf3);
			Assert.AreEqual(1, stage.Performers.Count);
		}

		[Test]
		public void ADDIfSongNUll_ANE()
		{
			Assert.Throws<ArgumentNullException>(() => stage.AddSong(null));			
		}

		[Test]
		public void ADDIfSongLessThan1Min_AE()
		{
			Assert.Throws<ArgumentException>(() => stage.AddSong(new Song("Ala", new TimeSpan(0,0,20))));
		}

		[Test]
		public void ADDSongToPerf_ANE_IfAnyNull()
		{
			Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer("Moq", null));
			Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer(null, "L"));
		}	

		[Test]
		public void IfPerfNullThroewsAE()
        {
			stage.AddPerformer(perf3);
			stage.AddSong(song2);
			Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("Moq", "Koko"));
			
		}

		[Test]
		public void IfSongNullThroewsAE()
		{
			stage.AddPerformer(perf3);
			stage.AddSong(song2);
			Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("00", "L J"));
		}

		[Test]
		public void TestPlay()
		{
			stage.AddPerformer(perf3);
			string expectedResult = $"1 performers played 0 songs";
			Assert.AreEqual(expectedResult, stage.Play());
			stage.AddSong(song2);
			stage.AddPerformer(perf4);
			stage.AddSong(new Song("Libe", new TimeSpan(0, 4, 23)));

			stage.AddSongToPerformer("Moq", "L J");
			stage.AddSongToPerformer("Libe", "J D");
			string expected = "2 performers played 2 songs";
			Assert.AreEqual(expected, stage.Play());
		}

		[Test] //4
		public void AddSongToPerfomer()
		{
			string songName = "Moq";
			string perfomer = "L J";

			stage.AddPerformer(perf3);

			stage.AddSong(song2);

			var expectedResult = $"Moq (03:45) will be performed by L J";
			Assert.AreEqual(expectedResult, stage.AddSongToPerformer(songName, perfomer));
		}
	}
}