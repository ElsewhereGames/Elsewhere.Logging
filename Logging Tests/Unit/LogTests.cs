
#region Using 

#region Testing

using NUnit.Framework;

#endregion Testing

#region Logging

using Elsewhere.Logging;

#endregion Logging

#endregion Using

namespace Elsewhere.Logging.Tests.Unit
{

    [TestFixture]
    public class LogTests
    {

        #region Constants

        private const string    DefaultName             = "log";
        private const Level     DefaultTreshold         = Level.Warning;
        private const Level     Alternativethreshold    = Level.Debug;

        #endregion Constants

        #region Tests

        [Test]
        public void CanCreateDefaultInstance()
        {
            Log log = new Log(LogTests.DefaultName);
            
            Assert.IsNotNull(log);
            Assert.AreEqual(LogTests.DefaultName, log.Name);
            Assert.AreEqual(LogTests.DefaultTreshold, log.Threshold);
        }

        [Test]
        public void CanSpecifyThreshold()
        {
            Log log = new Log(LogTests.DefaultName, LogTests.Alternativethreshold);

            Assert.IsNotNull(log);
            Assert.AreEqual(LogTests.DefaultName, log.Name);
            Assert.AreEqual(LogTests.Alternativethreshold, log.Threshold);
        }

        #endregion Tests

    }
}
