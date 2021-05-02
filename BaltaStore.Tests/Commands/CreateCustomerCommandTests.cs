using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests.Commands
{
    [TestClass]
    public class CreateCustomerCommandTests
    {
        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand
            {
                FirstName = "Bruno",
                LastName = "Araujo",
                Document = "12345678912",
                Email = "teste@hotmail.com",
                Phone = "19988789898"
            };

            Assert.AreEqual(true, command.Valid());
        }
    }
}