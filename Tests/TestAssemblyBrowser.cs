using AssemblyBrowserLibrary;
using AssemblyBrowserLibrary.AssemblyComposition;

namespace Tests
{
    public class TestAssemblyBrowser
    {
        private AssemblyInfo _assemblyInfo1, _assemblyInfo2;
        [OneTimeSetUp]
        public void Setup()
        {
            AssemblyBrowser assemblyBrowser1 = new AssemblyBrowser("D:\\term5\\SPP\\SPP_lab2\\FakerLibrary\\" +
                "GeneratorsDLL\\DoubleGenerator\\bin\\Debug\\net6.0\\DoubleGenerator.dll");
            _assemblyInfo1 = assemblyBrowser1.GetAssemblyInfo();

            AssemblyBrowser assemblyBrowser2 = new AssemblyBrowser("D:\\term5\\SPP\\SPP_lab2\\FakerLibrary\\" +
                "GeneratorsDLL\\DoubleGenerator\\bin\\Debug\\net6.0\\FakerLibrary.dll");
            _assemblyInfo2 = assemblyBrowser2.GetAssemblyInfo();
        }

        [Test]
        public void GetAssemblyInfo_AssemblyInfo_ReturnCorrectAssemblyName()
        {
            string correctAssemblyName = "DoubleGenerator";

            Assert.AreEqual(_assemblyInfo1.AssemblyName, correctAssemblyName);
        }

        [Test]
        public void GetAssemblyInfo_AssemblyInfo_ReturnCorrectNumberOfNamespaces()
        {
            int correctNumberOfNamespacies = 3;

            Assert.AreEqual(correctNumberOfNamespacies, _assemblyInfo1.Namespaces.Count);
        }

        [Test]
        public void GetAssemblyInfo_AssemblyInfo_ReturnCorrectNumberOfTypes()
        {
            int correctNumberOfTypes1 = 1;
            int correctNumberOfTypes2 = 5;

            var namespace1 = _assemblyInfo1.Namespaces;
            var namespace2 = _assemblyInfo2.Namespaces;

            Assert.AreEqual(correctNumberOfTypes1, namespace1[2].Types.Count);
            Assert.AreEqual(correctNumberOfTypes2, namespace2[2].Types.Count);
        }

        [Test]
        public void GetAssemblyInfo_AssemblyInfo_ReturnCorrectTypeOfTypes()
        {
            string typeDesc1 = _assemblyInfo1.Namespaces[2].Types[0].TypeDesc;
            string typeDesc2 = _assemblyInfo2.Namespaces[2].Types[2].TypeDesc;

            Assert.AreEqual("Class", typeDesc1);
            Assert.AreEqual("Interface", typeDesc2);
        }

        [Test]
        public void GetAssemblyInfo_AssemblyInfo_CorrectNumberOfMethods()
        {
            int methodCount = _assemblyInfo1.Namespaces[2].Types[0].Methods.Count;

            Assert.AreEqual(6, methodCount);
        }
    }
}