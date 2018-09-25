using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog8170_Assignment1;
using NUnit.Framework;

namespace Prog8170_Assignment1_Tests
{
    [TestFixture]

    class Prog8170_Assignment1_Tests
    {
        [Test]

       public void GetLength_Input2_expectLengthEquals2()
        {
            //Arrange
            int l = 2;
            int w = 3;
            Rectangle testrectangle = new Rectangle(l,w);

            //Act
            int length = testrectangle.GetLength();

            //Assert
            Assert.AreEqual(length,l);

        }

        [Test]
        public void SetLength_input3_expectLengthEquals3()
        {
            //Arrange
            int l=3;
            int w=3;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int length = testrectangle.SetLength(3);

            //Assert
            Assert.AreEqual(length, l);

        }
        [Test]
        public void GetWidth_input2_expectWidthEquals2()
        {
            //Arrange
            int l = 2;
            int w = 2;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int width = testrectangle.GetWidth();

            //Assert
            Assert.AreEqual(width,w);

        }
        [Test]
        public void SetWidth_input2_expectWidthEquals2()
        {
            //Arrange
            int l = 2;
            int w = 2;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int width = testrectangle.SetWidth(3);

            //Assert
            Assert.AreEqual(width, w);

        }
        [Test]
        public void Parameter_input_length2_input_width2_expectParameterEquals8()
        {
            //Arrange
            int l = 2;
            int w = 2;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int parameter = testrectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(parameter, 8);

        }
        [Test]
        public void Area_input_length1_input_width1_expectAreaEquals1()
        {
            //Arrange
            int l = 1;
            int w = 1;
            Rectangle testrectangle = new Rectangle(l, w);

            //Act
            int area = testrectangle.GetArea();

            //Assert
            Assert.AreEqual(area, 1);

        }
    }
}
