using MultimediaLibrary.Enums;
using MultimediaLibrary.Extensions;
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

namespace MultimediaLibrary.Test
{
    public class ExtensionsTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Should_GetDisplayName_Returns_AttributeName()
        {
            // Arrange
            var _book = "Ksi¹¿ka";
            var _journal = "Czasopismo";
            var _compactDisc = "P³yta CD";
            var _ebook = "E-book";
            var _audiobook = "Audio-book";
            var _pendrive = "Pendrive";

            // Act
            var book = SupplyType.Book.GetDisplayName();
            var journal = SupplyType.Journal.GetDisplayName();
            var compactDisc = SupplyType.CompactDisc.GetDisplayName();
            var ebook = SupplyType.Ebook.GetDisplayName();
            var audiobook = SupplyType.Audiobook.GetDisplayName();
            var pendrive = SupplyType.Pendrive.GetDisplayName();

            // Assert
            Assert.AreEqual(_book, book);
            Assert.AreEqual(_journal, journal);
            Assert.AreEqual(_compactDisc, compactDisc);
            Assert.AreEqual(_ebook, ebook);
            Assert.AreEqual(_audiobook, audiobook);
            Assert.AreEqual(_pendrive, pendrive);
        }

        [Test]
        public void Should_GetDisplayName_Returns_EmptyString()
        {
            // Arrange
            var _emptyString = string.Empty;
            var _inActive = "Nie aktywna";

            // Act
            var emptyString = StateTest.Active.GetDisplayName();
            var inActive = StateTest.InActive.GetDisplayName();

            // Assert
            Assert.AreEqual(_emptyString, emptyString);
            Assert.AreEqual(_inActive, inActive);
        }
    }

    public enum StateTest
    {
        Active = 1,

        [Display(Name = "Nie aktywna")]
        InActive = 2,
    }

}
