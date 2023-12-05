using Laboratorium3___App.Controllers;
using Laboratorium3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_9___App_tests
{
    public class ContactControllerTest
    {
        private ContactController _controller;
        private IContactService _service;
        private IDateTimeProvider _dateTimeProvider;

        public ContactControllerTest()
        {
            _dateTimeProvider = new CurrentDateTimeProvider();
            _service = new MemoryContactService(_dateTimeProvider);
            _service.Add(new Contact() { Id = 1 });
            _service.Add(new Contact() { Id = 2 });
            _controller = new ContactController(_service);
        }

        [Fact]
        public void IndexTest()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as List<Contact>;
            Assert.Equal(2, model.Count);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void DetailsTestForExistingContact(int id)
        {
            var result = _controller.Details(id);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Contact;
            Assert.Equal(id, model.Id);
        }

        [Theory]
        [InlineData(45)]
        [InlineData(99)]
        public void DetailsTestForNotExistingContact(int id)
        {
            var result = _controller.Details(id);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}