using NUnit.Framework;
using RadioApp;
namespace RadioTests
{
    public class RadioOffTests
    {
        private Radio _radio;
        [SetUp]
        public void Setup()
        {
            _radio = new Radio();
            _radio.TurnOff();
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void ChangeToValidChannelWhenOffTest(int newChannel)
        {
            _radio.Channel = newChannel;
            Assert.AreEqual(1, _radio.Channel);
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(5)]
        public void ChangeToInvalidChannelWhenOffTest(int newChannel)
        {
            // act
            _radio.Channel = newChannel;
            // assert
            Assert.AreEqual(1, _radio.Channel);
        }
        [Test]
        public void PlayTest()
        {
            // act
            var message = _radio.Play();
            // assert
            Assert.AreEqual("Radio is off", message);
        }

        [Test]
        public void TurnOnTest()
        {
            _radio.TurnOn();
            Assert.AreEqual("Playing channel 1", _radio.Play());
        }
    }
}