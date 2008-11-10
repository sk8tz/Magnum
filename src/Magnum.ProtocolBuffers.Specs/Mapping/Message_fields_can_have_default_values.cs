namespace Magnum.ProtocolBuffers.Specs
{
    using NUnit.Framework;
    using TestMessages;

    [TestFixture]
    public class Message_fields_can_have_default_values :
        Specification
    {
        private FieldMap<TestMessage> _mapping;

        protected override void Before_each()
        {
            _mapping = new FieldMap<TestMessage>(1, m=>m.Name);
        }
        [Test]
        public void Should_be_settable()
        {
            
            _mapping.SetDefaultValue("chris");

            Assert.IsTrue(_mapping.HasDefaultValue);
            Assert.AreEqual("chris", _mapping.DefaultValue);
        }

        [Test]
        public void By_default_there_should_be_no_default_value()
        {
            Assert.IsFalse(_mapping.HasDefaultValue);
        }
    }
}