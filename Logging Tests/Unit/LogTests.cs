
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

        #region Tests

        [Test]
        public void CanCreateDefaultInstance()
        {
            Log log = new Log();
            Assert.IsNotNull(log);
        }

        #endregion Tests

    }
}
