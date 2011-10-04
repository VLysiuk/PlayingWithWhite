using System;
using System.Threading;
using NUnit.Framework;
using White.Core.UIItems;
using White.Core.UIItems.ListBoxItems;
using White.Core.UIItems.WindowItems;

namespace PlayingWithWhite.Test.Acceptance
{
    [TestFixture]
    public class ChuckAcceptanceTest
    {
        private readonly ApplicationRunner _appRunner = new ApplicationRunner();
        private Window _chuckWindow;

        [SetUp]
        public void SetUp()
        {
            _appRunner.Launch();
            _appRunner.LogIn("Chuck Norris", "I'm Chuck Norris, babe!");
            _chuckWindow = _appRunner.MainWindow.ModalWindow("God Window");
        }

        [TearDown]
        public void TearDown()
        {
            _appRunner.StopApplication();
        }

        //NOTE: Be careful, it is Chuck Norris test!
        [Test]
        public void ShowMessageThatSelectedPersonWasKicked()
        {
            //get controls
            var victims = _chuckWindow.Get<ListBox>("_victimList");
            var kickType = _chuckWindow.Get<ComboBox>("_kickTypeComboBox");
            var kickTime = _chuckWindow.Get<DateTimePicker>("_kickDateTime");

            //set value
            var victim = victims.Items[1].Name;
            victims.Select(victim);
            kickType.Select(2);
            kickTime.Date = DateTime.Now.AddDays(1);

            //button click
            var kickButton = _chuckWindow.Get<Button>("_kickButton");
            kickButton.RaiseClickEvent();

            var kickResult = String.Format("{0} is going to be kicked with {1} at {2}", victims.SelectedItemText,
                                           kickType.SelectedItemText, kickTime.Date.ToShortDateString());

            var kickLabel = _chuckWindow.Get<Label>("_kickLabel");
            
            Assert.AreEqual(kickResult,kickLabel.Text);
        }

        [Test]
        public void CloseWindowWhenDecidedToSpareVictims()
        {
            var spareButton = _chuckWindow.Get<Button>("_spareButton");
            spareButton.RaiseClickEvent();

            Thread.Sleep(1000);
            Assert.IsTrue(_chuckWindow.IsClosed);
        }
    }
}
