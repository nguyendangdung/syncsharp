﻿using System;
using SyncSharp.Storage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestLogger
{
    
    
    /// <summary>
    ///This is a test class for LoggerTest and is intended
    ///to contain all LoggerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LoggerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for SyncSetWriteLog
        /// normal case. start
        ///</summary>
        [TestMethod()]
        public void SyncSetWriteLogTestStart1()
        {
            string machineId = "macID";
            string syncTaskName = "SyncSetWriteLogTestSTART"; 
            bool start = true; 
            bool expected = true;
            bool actual = false;            
                
            actual = Logger.SyncSetWriteLog(machineId, syncTaskName, start);            
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SyncSetWriteLog
        /// fail case. start. params null or empty
        ///</summary>
        [TestMethod()]
        public void SyncSetWriteLogTestStart2()
        {
            string machineId = "macID";
            string syncTaskName = "";
            bool start = true;
            bool expected = false;
            bool actual = true;
            try
            {
                actual = Logger.SyncSetWriteLog(machineId, syncTaskName, start);
            }
            catch(ArgumentException ae)
            {
                actual = false;
                Assert.AreEqual(expected, actual);
                Logger.WriteErrorLog(ae.Message);
                Logger.WriteErrorLog(ae.StackTrace);
                return; 
            }
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method. Check file output log.");
        }

        /// <summary>
        ///A test for SyncSetWriteLog
        /// normal case. end
        ///</summary>
        [TestMethod()]
        public void SyncSetWriteLogTestEnd1()
        {
            string machineId = "macID";
            string syncTaskName = "SyncSetWriteLogTestEND"; 
            bool start = false; 
            bool expected = true; 
            bool actual = false;

            WriteLogTest();
            actual = Logger.SyncSetWriteLog(machineId, syncTaskName, start);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SyncPlanWriteLog
        ///normal case
        [TestMethod()]
        public void SyncPlanWriteLogTest1()
        {
            string machineId = "macID";
            string syncTaskName = "SyncPlanWriteLog"; 
            int machineCopyTotal = 0; 
            long machineCopySize = 0; 
            int machineDeleteTotal = 0; 
            long machineDeleteSize = 0; 
            int machineRenameTotal = 0; 
            long machineRenameSize = 0; 
            int usbCopyTotal = 0; 
            long usbCopySize = 0; 
            int usbDeleteTotal = 0; 
            long usbDeleteSize = 0; 
            int usbRenameTotal = 0; 
            long usbRenameSize = 0; 
            bool expected = true; 
            bool actual = false;
            
            actual = Logger.SyncPlanWriteLog(machineId, syncTaskName, machineCopyTotal, machineCopySize, machineDeleteTotal, machineDeleteSize, machineRenameTotal, machineRenameSize, usbCopyTotal, usbCopySize, usbDeleteTotal, usbDeleteSize, usbRenameTotal, usbRenameSize);            
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SyncPlanWriteLog
        ///fail case. param null 
        [TestMethod()]
        public void SyncPlanWriteLogTest2()
        {
            string machineId = "macID";
            string syncTaskName = "";
            int machineCopyTotal = 0;
            long machineCopySize = 0;
            int machineDeleteTotal = 0;
            long machineDeleteSize = 0;
            int machineRenameTotal = 0;
            long machineRenameSize = 0;
            int usbCopyTotal = 0;
            long usbCopySize = 0;
            int usbDeleteTotal = 0;
            long usbDeleteSize = 0;
            int usbRenameTotal = 0;
            long usbRenameSize = 0;
            bool expected = false;
            bool actual = true;

            try
            {
                actual = Logger.SyncPlanWriteLog(machineId, syncTaskName, machineCopyTotal, machineCopySize, machineDeleteTotal, machineDeleteSize, machineRenameTotal, machineRenameSize, usbCopyTotal, usbCopySize, usbDeleteTotal, usbDeleteSize, usbRenameTotal, usbRenameSize);
            }
            catch (ArgumentException ae)
            {
                actual = false;
                Assert.AreEqual(expected, actual);
                Logger.WriteErrorLog(ae.Message);
                Logger.WriteErrorLog(ae.StackTrace);
                return;
            }
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method. Check file output log.");
        }

        /// <summary>
        ///A test for SyncPlanWriteLog
        ///fail case. param null 
        [TestMethod()]
        public void SyncPlanWriteLogTest3()
        {
            string machineId = null;
            string syncTaskName = "syt1";
            int machineCopyTotal = 0;
            long machineCopySize = 0;
            int machineDeleteTotal = 0;
            long machineDeleteSize = 0;
            int machineRenameTotal = 0;
            long machineRenameSize = 0;
            int usbCopyTotal = 0;
            long usbCopySize = 0;
            int usbDeleteTotal = 0;
            long usbDeleteSize = 0;
            int usbRenameTotal = 0;
            long usbRenameSize = 0;
            bool expected = false;
            bool actual = true;

            try
            {
                actual = Logger.SyncPlanWriteLog(machineId, syncTaskName, machineCopyTotal, machineCopySize, machineDeleteTotal, machineDeleteSize, machineRenameTotal, machineRenameSize, usbCopyTotal, usbCopySize, usbDeleteTotal, usbDeleteSize, usbRenameTotal, usbRenameSize);
            }
            catch (ArgumentNullException ane)
            {
                actual = false;
                Assert.AreEqual(expected, actual);
                Logger.WriteErrorLog(ane.Message);
                Logger.WriteErrorLog(ane.StackTrace);
                return;
            }
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method. Check file output log.");
        }

        /// <summary>
        ///A test for SyncPlanWriteLog
        ///fail case. param out of range, -ve
        [TestMethod()]
        public void SyncPlanWriteLogTest4()
        {
            string machineId = "mac1";
            string syncTaskName = "syt1";
            int machineCopyTotal = 0;
            long machineCopySize = 0;
            int machineDeleteTotal = -4;
            long machineDeleteSize = 0;
            int machineRenameTotal = 0;
            long machineRenameSize = 0;
            int usbCopyTotal = 0;
            long usbCopySize = 0;
            int usbDeleteTotal = 0;
            long usbDeleteSize = 0;
            int usbRenameTotal = 0;
            long usbRenameSize = 0;
            bool expected = false;
            bool actual = true;

            try
            {
                actual = Logger.SyncPlanWriteLog(machineId, syncTaskName, machineCopyTotal, machineCopySize, machineDeleteTotal, machineDeleteSize, machineRenameTotal, machineRenameSize, usbCopyTotal, usbCopySize, usbDeleteTotal, usbDeleteSize, usbRenameTotal, usbRenameSize);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                actual = false;
                Assert.AreEqual(expected, actual);
                Logger.WriteErrorLog(aoore.Message);
                Logger.WriteErrorLog(aoore.StackTrace);
                return;
            }
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method. Check file output log.");
        }

        /// <summary>
        ///A test for WriteLog
        /// normal case
        /// machine copy
        ///</summary>
        [TestMethod()]
        public void WriteLogTest()
        {
            int logType = (int) Logger.LogType.Copy; 
            string machineId = "macID";
            string syncTaskName = "SyncPlanWriteLog"; 
            string machineSrcPath = @"C:\anc\can\abc.ind"; 
            long machineSrcSize = 6546890; 
            string machineDestPath = @"H:\anc\can\abc.ind"; 
            long machineDestSize = 6546890; 
            string usbSrcPath = null;
            long usbSrcSize = 0; 
            string usbDestPath = null; 
            long usbDestSize = 0; 
            string errorMsg = null; 
            bool expected = true; 
            bool actual;
            actual = Logger.WriteLog(logType, machineId, syncTaskName, machineSrcPath, machineSrcSize, machineDestPath, machineDestSize, usbSrcPath, usbSrcSize, usbDestPath, usbDestSize, errorMsg);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteLog
        /// fail case
        /// LogType invalid
        ///</summary>
        [TestMethod()]
        public void WriteLogTest2()
        {
            int logType = 20;
            string machineId = "macID";
            string syncTaskName = "SyncPlanWriteLog";
            string machineSrcPath = @"C:\anc\can\abc.ind";
            long machineSrcSize = 6546890;
            string machineDestPath = @"H:\anc\can\abc.ind";
            long machineDestSize = 6546890;
            string usbSrcPath = null;
            long usbSrcSize = 0;
            string usbDestPath = null;
            long usbDestSize = 0;
            string errorMsg = null;
            bool expected = false;
            bool actual = true;
            try
            {
                actual = Logger.WriteLog(logType, machineId, syncTaskName, machineSrcPath, machineSrcSize, machineDestPath,
                                             machineDestSize, usbSrcPath, usbSrcSize, usbDestPath, usbDestSize, errorMsg);
            }
            catch (ArgumentException ae)
            {
                actual = false;
                Assert.AreEqual(expected, actual);
                Logger.WriteErrorLog(ae.Message);
                Logger.WriteErrorLog(ae.StackTrace);
                return;
            }
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteLog
        /// fail case
        /// LogType invalid
        ///</summary>
        [TestMethod()]
        public void WriteLogTest3()
        {
            int logType = (int)Logger.LogType.Rename;
            string machineId = "macID";
            string syncTaskName = "SyncPlanWriteLog";
            string machineSrcPath = @"C:\anc\can\abc.ind";
            long machineSrcSize = 6546890;
            string machineDestPath = @"H:\anc\can\abc.ind";
            long machineDestSize = -6546890;
            string usbSrcPath = null;
            long usbSrcSize = 0;
            string usbDestPath = null;
            long usbDestSize = 0;
            string errorMsg = null;
            bool expected = false;
            bool actual = true;
            try
            {
                actual = Logger.WriteLog(logType, machineId, syncTaskName, machineSrcPath, machineSrcSize, machineDestPath,
                                             machineDestSize, usbSrcPath, usbSrcSize, usbDestPath, usbDestSize, errorMsg);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                actual = false;
                Assert.AreEqual(expected, actual);
                Logger.WriteErrorLog(aoore.Message);
                Logger.WriteErrorLog(aoore.StackTrace);
                return;
            }
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteLog
        /// fail case
        /// machine copy
        ///</summary>
        [TestMethod()]
        public void WriteLogTest4()
        {
            int logType = (int)Logger.LogType.Copy;
            string machineId = "macID";
            string syncTaskName = "SyncPlanWriteLog";
            string machineSrcPath = @"C:\anc\can\abc.ind";
            long machineSrcSize = 6546890;
            string machineDestPath = @"H:\anc\can\abc.ind";
            long machineDestSize = 6546890;
            string usbSrcPath = null;
            long usbSrcSize = 0;
            string usbDestPath = @"H:\anc\can\abc.ind";
            long usbDestSize = 0;
            string errorMsg = @"H:\anc\can\abc.ind";
            bool expected = false;
            bool actual;
            actual = Logger.WriteLog(logType, machineId, syncTaskName, machineSrcPath, machineSrcSize, machineDestPath, machineDestSize, usbSrcPath, usbSrcSize, usbDestPath, usbDestSize, errorMsg);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteErrorLog
        ///normal case
        [TestMethod()]
        public void WriteErrorLogTest()
        {
            string errorMsg = "klsfskldfn";
            bool expected = true; 
            bool actual;
            actual = Logger.WriteErrorLog(errorMsg);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WriteErrorLog
        ///fail case
        /// empty string passed
        [TestMethod()]
        public void WriteErrorLogTest2()
        {
            //string errorMsg = string.Empty;
            string errorMsg = "";
            bool expected = false; 
            bool actual = true;
            try
            {
                actual = Logger.WriteErrorLog(errorMsg);
            }
            catch (ArgumentException ae)
            {
                actual = false;
                Assert.AreEqual(expected, actual);
                Logger.WriteErrorLog(ae.Message);
                Logger.WriteErrorLog(ae.StackTrace);
                return;
            }
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method. Check file output error log.");
        }

        /// <summary>
        ///A test for WriteErrorLog
        ///fail case
        /// null param
        [TestMethod()]
        public void WriteErrorLogTest3()
        {
            string errorMsg = null;
            bool expected = false;
            bool actual = true; 
            
	        try{	        
	            actual = Logger.WriteErrorLog(errorMsg);	
	        }
	        catch (ArgumentNullException ane)
	        {
                actual = false;
                Assert.AreEqual(expected, actual);
	            Logger.WriteErrorLog(ane.Message);
                Logger.WriteErrorLog(ane.StackTrace);	
                return;
	        }
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method. Check file output error log.");
        }
    }
}
