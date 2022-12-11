﻿using NUnit.Framework;

namespace LeetCode.com._00051_N_Queens
{
    [TestFixture]
    public partial class SolveNQueensTest
    {
        
        #region 可用空間刪去

        static IEnumerable<TestCaseData> AreaDiff
        {
            get
            {
                yield return
                    new TestCaseData(
                        new Dictionary<string,bool>()
                        {
                            {"1,1", true},	{"1,2", true},	{"1,3", true},	{"1,4", true},
                            {"2,1", true},	{"2,2", true},	{"2,3", true},	{"2,4", true},
                            {"3,1", true},	{"3,2", true},	{"3,3", true},	{"3,4", true},
                            {"4,1", true},	{"4,2", true},	{"4,3", true},	{"4,4", true},
                        },
                        new Dictionary<string,bool>()
                        {
                            {"1,1", true},	{"1,2", true},	{"1,3", true},	{"1,4", true},
                            {"2,1", true},	{"2,2", true},	{"2,3", true},	{"2,4", true},
                        }
                        ,new Dictionary<string,bool>()
                        {
                            {"3,1", true},	{"3,2", true},	{"3,3", true},	{"3,4", true},
                            {"4,1", true},	{"4,2", true},	{"4,3", true},	{"4,4", true},
                        }
                        );

                yield return
                    new TestCaseData(
                        new Dictionary<string,bool>()
                        {
                            {"1,1", true},	{"1,2", true},	{"1,3", true},	{"1,4", true},	{"1,5", true},	{"1,6", true},	{"1,7", true},
                            {"2,1", true},	{"2,2", true},	{"2,3", true},	{"2,4", true},	{"2,5", true},	{"2,6", true},	{"2,7", true},
                            {"3,1", true},	{"3,2", true},	{"3,3", true},	{"3,4", true},	{"3,5", true},	{"3,6", true},	{"3,7", true},
                            {"4,1", true},	{"4,2", true},	{"4,3", true},	{"4,4", true},	{"4,5", true},	{"4,6", true},	{"4,7", true},
                            {"5,1", true},	{"5,2", true},	{"5,3", true},	{"5,4", true},	{"5,5", true},	{"5,6", true},	{"5,7", true},
                            {"6,1", true},	{"6,2", true},	{"6,3", true},	{"6,4", true},	{"6,5", true},	{"6,6", true},	{"6,7", true},
                            {"7,1", true},	{"7,2", true},	{"7,3", true},	{"7,4", true},	{"7,5", true},	{"7,6", true},	{"7,7", true},

                        },
                        new Dictionary<string,bool>()
                        {
                            {"3,1", true},	{"3,2", true},	{"3,3", true},	{"3,4", true},	{"3,5", true},	{"3,6", true},	{"3,7", true},
                            {"4,1", true},	{"4,2", true},	{"4,3", true},	{"4,4", true},	{"4,5", true},	{"4,6", true},	{"4,7", true},
                            {"7,1", true},	{"7,2", true},	{"7,3", true},	{"7,4", true},	{"7,5", true},	{"7,6", true},	{"7,7", true},

                        }
                        ,new Dictionary<string,bool>()
                        {
                            {"1,1", true},	{"1,2", true},	{"1,3", true},	{"1,4", true},	{"1,5", true},	{"1,6", true},	{"1,7", true},
                            {"2,1", true},	{"2,2", true},	{"2,3", true},	{"2,4", true},	{"2,5", true},	{"2,6", true},	{"2,7", true},
                            {"5,1", true},	{"5,2", true},	{"5,3", true},	{"5,4", true},	{"5,5", true},	{"5,6", true},	{"5,7", true},
                            {"6,1", true},	{"6,2", true},	{"6,3", true},	{"6,4", true},	{"6,5", true},	{"6,6", true},	{"6,7", true},
                        }
                    );
            }
        }

        #endregion
        
        #region 答案測試

        static IEnumerable<TestCaseData> SolveNQueens
        {
            get
            {
                yield return
                    new TestCaseData(4, new List<List<string>>()
                    {
                        new()
                        {
                            ".Q..", "...Q", "Q...", "..Q."
                        },
                        new()
                        {
                            "..Q.", "Q...", "...Q", ".Q.."
                        }
                    });

                yield return
                    new TestCaseData(1, new List<List<string>>()
                    {
                        new()
                        {
                            "Q"
                        }
                    });
            }
        }

        #endregion
        
        #region 答案測試

        static IEnumerable<TestCaseData> QueensExclusionArea
        {
            get
            {
                yield return
                    new TestCaseData("1,1", 4, new Dictionary<string,bool>()
                    {
                        {"1,1", true},{"1,2", true},{"1,3", true},{"1,4", true},
                        {"2,1", true},{"2,2", true},
                        {"3,1", true},              {"3,3", true},
                        {"4,1", true},                            {"4,4", true},
                    });
                
                yield return
                    new TestCaseData("2,3", 4,new Dictionary<string,bool>()
                    {
                                                                        
                                        {"1,2", true},  {"1,3", true},  {"1,4", true},
                        {"2,1", true},  {"2,2", true},  {"2,3", true},  {"2,4", true},
                                        {"3,2", true},  {"3,3", true},  {"3,4", true},
                        {"4,1", true},                  {"4,3", true}, 
                    });
                
                yield return
                    new TestCaseData("4,4", 7,new Dictionary<string,bool>()
                    {
                                                                        
                        {"1,1", true},		                            {"1,4", true},	                                {"1,7", true},
                                        {"2,2", true},	               	{"2,4", true},	              	{"2,6", true},
                                                       	{"3,3", true},	{"3,4", true},	{"3,5", true},
                        {"4,1", true},	{"4,2", true},	{"4,3", true},	{"4,4", true},	{"4,5", true},	{"4,6", true},	{"4,7", true},
                                                     	{"5,3", true},	{"5,4", true},	{"5,5", true},
                                        {"6,2", true},	              	{"6,4", true},	             	{"6,6", true},
                        {"7,1", true},	                                {"7,4", true},	                              	{"7,7", true},
                    });
            }
        }

        #endregion
        
        #region 棋盤繪製驗證

        static IEnumerable<TestCaseData> CreateCheckerBoard
        {
            get
            {
                yield return
                    new TestCaseData(4, new Dictionary<string, bool>()
                    {
                        {"1,1", true}, {"1,2", true}, {"1,3", true}, {"1,4", true}, {"2,1", true}, {"2,2", true},
                        {"2,3", true}, {"2,4", true}, {"3,1", true}, {"3,2", true}, {"3,3", true}, {"3,4", true},
                        {"4,1", true}, {"4,2", true}, {"4,3", true}, {"4,4", true},
                    });

                yield return
                    new TestCaseData(30, new Dictionary<string, bool>()
                    {
                        {"1,1", true}, {"1,2", true}, {"1,3", true}, {"1,4", true}, {"1,5", true}, {"1,6", true},
                        {"1,7", true}, {"1,8", true}, {"1,9", true}, {"1,10", true}, {"1,11", true}, {"1,12", true},
                        {"1,13", true}, {"1,14", true}, {"1,15", true}, {"1,16", true}, {"1,17", true}, {"1,18", true},
                        {"1,19", true}, {"1,20", true}, {"1,21", true}, {"1,22", true}, {"1,23", true}, {"1,24", true},
                        {"1,25", true}, {"1,26", true}, {"1,27", true}, {"1,28", true}, {"1,29", true}, {"1,30", true},
                        {"2,1", true}, {"2,2", true}, {"2,3", true}, {"2,4", true}, {"2,5", true}, {"2,6", true},
                        {"2,7", true}, {"2,8", true}, {"2,9", true}, {"2,10", true}, {"2,11", true}, {"2,12", true},
                        {"2,13", true}, {"2,14", true}, {"2,15", true}, {"2,16", true}, {"2,17", true}, {"2,18", true},
                        {"2,19", true}, {"2,20", true}, {"2,21", true}, {"2,22", true}, {"2,23", true}, {"2,24", true},
                        {"2,25", true}, {"2,26", true}, {"2,27", true}, {"2,28", true}, {"2,29", true}, {"2,30", true},
                        {"3,1", true}, {"3,2", true}, {"3,3", true}, {"3,4", true}, {"3,5", true}, {"3,6", true},
                        {"3,7", true}, {"3,8", true}, {"3,9", true}, {"3,10", true}, {"3,11", true}, {"3,12", true},
                        {"3,13", true}, {"3,14", true}, {"3,15", true}, {"3,16", true}, {"3,17", true}, {"3,18", true},
                        {"3,19", true}, {"3,20", true}, {"3,21", true}, {"3,22", true}, {"3,23", true}, {"3,24", true},
                        {"3,25", true}, {"3,26", true}, {"3,27", true}, {"3,28", true}, {"3,29", true}, {"3,30", true},
                        {"4,1", true}, {"4,2", true}, {"4,3", true}, {"4,4", true}, {"4,5", true}, {"4,6", true},
                        {"4,7", true}, {"4,8", true}, {"4,9", true}, {"4,10", true}, {"4,11", true}, {"4,12", true},
                        {"4,13", true}, {"4,14", true}, {"4,15", true}, {"4,16", true}, {"4,17", true}, {"4,18", true},
                        {"4,19", true}, {"4,20", true}, {"4,21", true}, {"4,22", true}, {"4,23", true}, {"4,24", true},
                        {"4,25", true}, {"4,26", true}, {"4,27", true}, {"4,28", true}, {"4,29", true}, {"4,30", true},
                        {"5,1", true}, {"5,2", true}, {"5,3", true}, {"5,4", true}, {"5,5", true}, {"5,6", true},
                        {"5,7", true}, {"5,8", true}, {"5,9", true}, {"5,10", true}, {"5,11", true}, {"5,12", true},
                        {"5,13", true}, {"5,14", true}, {"5,15", true}, {"5,16", true}, {"5,17", true}, {"5,18", true},
                        {"5,19", true}, {"5,20", true}, {"5,21", true}, {"5,22", true}, {"5,23", true}, {"5,24", true},
                        {"5,25", true}, {"5,26", true}, {"5,27", true}, {"5,28", true}, {"5,29", true}, {"5,30", true},
                        {"6,1", true}, {"6,2", true}, {"6,3", true}, {"6,4", true}, {"6,5", true}, {"6,6", true},
                        {"6,7", true}, {"6,8", true}, {"6,9", true}, {"6,10", true}, {"6,11", true}, {"6,12", true},
                        {"6,13", true}, {"6,14", true}, {"6,15", true}, {"6,16", true}, {"6,17", true}, {"6,18", true},
                        {"6,19", true}, {"6,20", true}, {"6,21", true}, {"6,22", true}, {"6,23", true}, {"6,24", true},
                        {"6,25", true}, {"6,26", true}, {"6,27", true}, {"6,28", true}, {"6,29", true}, {"6,30", true},
                        {"7,1", true}, {"7,2", true}, {"7,3", true}, {"7,4", true}, {"7,5", true}, {"7,6", true},
                        {"7,7", true}, {"7,8", true}, {"7,9", true}, {"7,10", true}, {"7,11", true}, {"7,12", true},
                        {"7,13", true}, {"7,14", true}, {"7,15", true}, {"7,16", true}, {"7,17", true}, {"7,18", true},
                        {"7,19", true}, {"7,20", true}, {"7,21", true}, {"7,22", true}, {"7,23", true}, {"7,24", true},
                        {"7,25", true}, {"7,26", true}, {"7,27", true}, {"7,28", true}, {"7,29", true}, {"7,30", true},
                        {"8,1", true}, {"8,2", true}, {"8,3", true}, {"8,4", true}, {"8,5", true}, {"8,6", true},
                        {"8,7", true}, {"8,8", true}, {"8,9", true}, {"8,10", true}, {"8,11", true}, {"8,12", true},
                        {"8,13", true}, {"8,14", true}, {"8,15", true}, {"8,16", true}, {"8,17", true}, {"8,18", true},
                        {"8,19", true}, {"8,20", true}, {"8,21", true}, {"8,22", true}, {"8,23", true}, {"8,24", true},
                        {"8,25", true}, {"8,26", true}, {"8,27", true}, {"8,28", true}, {"8,29", true}, {"8,30", true},
                        {"9,1", true}, {"9,2", true}, {"9,3", true}, {"9,4", true}, {"9,5", true}, {"9,6", true},
                        {"9,7", true}, {"9,8", true}, {"9,9", true}, {"9,10", true}, {"9,11", true}, {"9,12", true},
                        {"9,13", true}, {"9,14", true}, {"9,15", true}, {"9,16", true}, {"9,17", true}, {"9,18", true},
                        {"9,19", true}, {"9,20", true}, {"9,21", true}, {"9,22", true}, {"9,23", true}, {"9,24", true},
                        {"9,25", true}, {"9,26", true}, {"9,27", true}, {"9,28", true}, {"9,29", true}, {"9,30", true},
                        {"10,1", true}, {"10,2", true}, {"10,3", true}, {"10,4", true}, {"10,5", true}, {"10,6", true},
                        {"10,7", true}, {"10,8", true}, {"10,9", true}, {"10,10", true}, {"10,11", true},
                        {"10,12", true}, {"10,13", true}, {"10,14", true}, {"10,15", true}, {"10,16", true},
                        {"10,17", true}, {"10,18", true}, {"10,19", true}, {"10,20", true}, {"10,21", true},
                        {"10,22", true}, {"10,23", true}, {"10,24", true}, {"10,25", true}, {"10,26", true},
                        {"10,27", true}, {"10,28", true}, {"10,29", true}, {"10,30", true}, {"11,1", true},
                        {"11,2", true}, {"11,3", true}, {"11,4", true}, {"11,5", true}, {"11,6", true}, {"11,7", true},
                        {"11,8", true}, {"11,9", true}, {"11,10", true}, {"11,11", true}, {"11,12", true},
                        {"11,13", true}, {"11,14", true}, {"11,15", true}, {"11,16", true}, {"11,17", true},
                        {"11,18", true}, {"11,19", true}, {"11,20", true}, {"11,21", true}, {"11,22", true},
                        {"11,23", true}, {"11,24", true}, {"11,25", true}, {"11,26", true}, {"11,27", true},
                        {"11,28", true}, {"11,29", true}, {"11,30", true}, {"12,1", true}, {"12,2", true},
                        {"12,3", true}, {"12,4", true}, {"12,5", true}, {"12,6", true}, {"12,7", true}, {"12,8", true},
                        {"12,9", true}, {"12,10", true}, {"12,11", true}, {"12,12", true}, {"12,13", true},
                        {"12,14", true}, {"12,15", true}, {"12,16", true}, {"12,17", true}, {"12,18", true},
                        {"12,19", true}, {"12,20", true}, {"12,21", true}, {"12,22", true}, {"12,23", true},
                        {"12,24", true}, {"12,25", true}, {"12,26", true}, {"12,27", true}, {"12,28", true},
                        {"12,29", true}, {"12,30", true}, {"13,1", true}, {"13,2", true}, {"13,3", true},
                        {"13,4", true}, {"13,5", true}, {"13,6", true}, {"13,7", true}, {"13,8", true}, {"13,9", true},
                        {"13,10", true}, {"13,11", true}, {"13,12", true}, {"13,13", true}, {"13,14", true},
                        {"13,15", true}, {"13,16", true}, {"13,17", true}, {"13,18", true}, {"13,19", true},
                        {"13,20", true}, {"13,21", true}, {"13,22", true}, {"13,23", true}, {"13,24", true},
                        {"13,25", true}, {"13,26", true}, {"13,27", true}, {"13,28", true}, {"13,29", true},
                        {"13,30", true}, {"14,1", true}, {"14,2", true}, {"14,3", true}, {"14,4", true}, {"14,5", true},
                        {"14,6", true}, {"14,7", true}, {"14,8", true}, {"14,9", true}, {"14,10", true},
                        {"14,11", true}, {"14,12", true}, {"14,13", true}, {"14,14", true}, {"14,15", true},
                        {"14,16", true}, {"14,17", true}, {"14,18", true}, {"14,19", true}, {"14,20", true},
                        {"14,21", true}, {"14,22", true}, {"14,23", true}, {"14,24", true}, {"14,25", true},
                        {"14,26", true}, {"14,27", true}, {"14,28", true}, {"14,29", true}, {"14,30", true},
                        {"15,1", true}, {"15,2", true}, {"15,3", true}, {"15,4", true}, {"15,5", true}, {"15,6", true},
                        {"15,7", true}, {"15,8", true}, {"15,9", true}, {"15,10", true}, {"15,11", true},
                        {"15,12", true}, {"15,13", true}, {"15,14", true}, {"15,15", true}, {"15,16", true},
                        {"15,17", true}, {"15,18", true}, {"15,19", true}, {"15,20", true}, {"15,21", true},
                        {"15,22", true}, {"15,23", true}, {"15,24", true}, {"15,25", true}, {"15,26", true},
                        {"15,27", true}, {"15,28", true}, {"15,29", true}, {"15,30", true}, {"16,1", true},
                        {"16,2", true}, {"16,3", true}, {"16,4", true}, {"16,5", true}, {"16,6", true}, {"16,7", true},
                        {"16,8", true}, {"16,9", true}, {"16,10", true}, {"16,11", true}, {"16,12", true},
                        {"16,13", true}, {"16,14", true}, {"16,15", true}, {"16,16", true}, {"16,17", true},
                        {"16,18", true}, {"16,19", true}, {"16,20", true}, {"16,21", true}, {"16,22", true},
                        {"16,23", true}, {"16,24", true}, {"16,25", true}, {"16,26", true}, {"16,27", true},
                        {"16,28", true}, {"16,29", true}, {"16,30", true}, {"17,1", true}, {"17,2", true},
                        {"17,3", true}, {"17,4", true}, {"17,5", true}, {"17,6", true}, {"17,7", true}, {"17,8", true},
                        {"17,9", true}, {"17,10", true}, {"17,11", true}, {"17,12", true}, {"17,13", true},
                        {"17,14", true}, {"17,15", true}, {"17,16", true}, {"17,17", true}, {"17,18", true},
                        {"17,19", true}, {"17,20", true}, {"17,21", true}, {"17,22", true}, {"17,23", true},
                        {"17,24", true}, {"17,25", true}, {"17,26", true}, {"17,27", true}, {"17,28", true},
                        {"17,29", true}, {"17,30", true}, {"18,1", true}, {"18,2", true}, {"18,3", true},
                        {"18,4", true}, {"18,5", true}, {"18,6", true}, {"18,7", true}, {"18,8", true}, {"18,9", true},
                        {"18,10", true}, {"18,11", true}, {"18,12", true}, {"18,13", true}, {"18,14", true},
                        {"18,15", true}, {"18,16", true}, {"18,17", true}, {"18,18", true}, {"18,19", true},
                        {"18,20", true}, {"18,21", true}, {"18,22", true}, {"18,23", true}, {"18,24", true},
                        {"18,25", true}, {"18,26", true}, {"18,27", true}, {"18,28", true}, {"18,29", true},
                        {"18,30", true}, {"19,1", true}, {"19,2", true}, {"19,3", true}, {"19,4", true}, {"19,5", true},
                        {"19,6", true}, {"19,7", true}, {"19,8", true}, {"19,9", true}, {"19,10", true},
                        {"19,11", true}, {"19,12", true}, {"19,13", true}, {"19,14", true}, {"19,15", true},
                        {"19,16", true}, {"19,17", true}, {"19,18", true}, {"19,19", true}, {"19,20", true},
                        {"19,21", true}, {"19,22", true}, {"19,23", true}, {"19,24", true}, {"19,25", true},
                        {"19,26", true}, {"19,27", true}, {"19,28", true}, {"19,29", true}, {"19,30", true},
                        {"20,1", true}, {"20,2", true}, {"20,3", true}, {"20,4", true}, {"20,5", true}, {"20,6", true},
                        {"20,7", true}, {"20,8", true}, {"20,9", true}, {"20,10", true}, {"20,11", true},
                        {"20,12", true}, {"20,13", true}, {"20,14", true}, {"20,15", true}, {"20,16", true},
                        {"20,17", true}, {"20,18", true}, {"20,19", true}, {"20,20", true}, {"20,21", true},
                        {"20,22", true}, {"20,23", true}, {"20,24", true}, {"20,25", true}, {"20,26", true},
                        {"20,27", true}, {"20,28", true}, {"20,29", true}, {"20,30", true}, {"21,1", true},
                        {"21,2", true}, {"21,3", true}, {"21,4", true}, {"21,5", true}, {"21,6", true}, {"21,7", true},
                        {"21,8", true}, {"21,9", true}, {"21,10", true}, {"21,11", true}, {"21,12", true},
                        {"21,13", true}, {"21,14", true}, {"21,15", true}, {"21,16", true}, {"21,17", true},
                        {"21,18", true}, {"21,19", true}, {"21,20", true}, {"21,21", true}, {"21,22", true},
                        {"21,23", true}, {"21,24", true}, {"21,25", true}, {"21,26", true}, {"21,27", true},
                        {"21,28", true}, {"21,29", true}, {"21,30", true}, {"22,1", true}, {"22,2", true},
                        {"22,3", true}, {"22,4", true}, {"22,5", true}, {"22,6", true}, {"22,7", true}, {"22,8", true},
                        {"22,9", true}, {"22,10", true}, {"22,11", true}, {"22,12", true}, {"22,13", true},
                        {"22,14", true}, {"22,15", true}, {"22,16", true}, {"22,17", true}, {"22,18", true},
                        {"22,19", true}, {"22,20", true}, {"22,21", true}, {"22,22", true}, {"22,23", true},
                        {"22,24", true}, {"22,25", true}, {"22,26", true}, {"22,27", true}, {"22,28", true},
                        {"22,29", true}, {"22,30", true}, {"23,1", true}, {"23,2", true}, {"23,3", true},
                        {"23,4", true}, {"23,5", true}, {"23,6", true}, {"23,7", true}, {"23,8", true}, {"23,9", true},
                        {"23,10", true}, {"23,11", true}, {"23,12", true}, {"23,13", true}, {"23,14", true},
                        {"23,15", true}, {"23,16", true}, {"23,17", true}, {"23,18", true}, {"23,19", true},
                        {"23,20", true}, {"23,21", true}, {"23,22", true}, {"23,23", true}, {"23,24", true},
                        {"23,25", true}, {"23,26", true}, {"23,27", true}, {"23,28", true}, {"23,29", true},
                        {"23,30", true}, {"24,1", true}, {"24,2", true}, {"24,3", true}, {"24,4", true}, {"24,5", true},
                        {"24,6", true}, {"24,7", true}, {"24,8", true}, {"24,9", true}, {"24,10", true},
                        {"24,11", true}, {"24,12", true}, {"24,13", true}, {"24,14", true}, {"24,15", true},
                        {"24,16", true}, {"24,17", true}, {"24,18", true}, {"24,19", true}, {"24,20", true},
                        {"24,21", true}, {"24,22", true}, {"24,23", true}, {"24,24", true}, {"24,25", true},
                        {"24,26", true}, {"24,27", true}, {"24,28", true}, {"24,29", true}, {"24,30", true},
                        {"25,1", true}, {"25,2", true}, {"25,3", true}, {"25,4", true}, {"25,5", true}, {"25,6", true},
                        {"25,7", true}, {"25,8", true}, {"25,9", true}, {"25,10", true}, {"25,11", true},
                        {"25,12", true}, {"25,13", true}, {"25,14", true}, {"25,15", true}, {"25,16", true},
                        {"25,17", true}, {"25,18", true}, {"25,19", true}, {"25,20", true}, {"25,21", true},
                        {"25,22", true}, {"25,23", true}, {"25,24", true}, {"25,25", true}, {"25,26", true},
                        {"25,27", true}, {"25,28", true}, {"25,29", true}, {"25,30", true}, {"26,1", true},
                        {"26,2", true}, {"26,3", true}, {"26,4", true}, {"26,5", true}, {"26,6", true}, {"26,7", true},
                        {"26,8", true}, {"26,9", true}, {"26,10", true}, {"26,11", true}, {"26,12", true},
                        {"26,13", true}, {"26,14", true}, {"26,15", true}, {"26,16", true}, {"26,17", true},
                        {"26,18", true}, {"26,19", true}, {"26,20", true}, {"26,21", true}, {"26,22", true},
                        {"26,23", true}, {"26,24", true}, {"26,25", true}, {"26,26", true}, {"26,27", true},
                        {"26,28", true}, {"26,29", true}, {"26,30", true}, {"27,1", true}, {"27,2", true},
                        {"27,3", true}, {"27,4", true}, {"27,5", true}, {"27,6", true}, {"27,7", true}, {"27,8", true},
                        {"27,9", true}, {"27,10", true}, {"27,11", true}, {"27,12", true}, {"27,13", true},
                        {"27,14", true}, {"27,15", true}, {"27,16", true}, {"27,17", true}, {"27,18", true},
                        {"27,19", true}, {"27,20", true}, {"27,21", true}, {"27,22", true}, {"27,23", true},
                        {"27,24", true}, {"27,25", true}, {"27,26", true}, {"27,27", true}, {"27,28", true},
                        {"27,29", true}, {"27,30", true}, {"28,1", true}, {"28,2", true}, {"28,3", true},
                        {"28,4", true}, {"28,5", true}, {"28,6", true}, {"28,7", true}, {"28,8", true}, {"28,9", true},
                        {"28,10", true}, {"28,11", true}, {"28,12", true}, {"28,13", true}, {"28,14", true},
                        {"28,15", true}, {"28,16", true}, {"28,17", true}, {"28,18", true}, {"28,19", true},
                        {"28,20", true}, {"28,21", true}, {"28,22", true}, {"28,23", true}, {"28,24", true},
                        {"28,25", true}, {"28,26", true}, {"28,27", true}, {"28,28", true}, {"28,29", true},
                        {"28,30", true}, {"29,1", true}, {"29,2", true}, {"29,3", true}, {"29,4", true}, {"29,5", true},
                        {"29,6", true}, {"29,7", true}, {"29,8", true}, {"29,9", true}, {"29,10", true},
                        {"29,11", true}, {"29,12", true}, {"29,13", true}, {"29,14", true}, {"29,15", true},
                        {"29,16", true}, {"29,17", true}, {"29,18", true}, {"29,19", true}, {"29,20", true},
                        {"29,21", true}, {"29,22", true}, {"29,23", true}, {"29,24", true}, {"29,25", true},
                        {"29,26", true}, {"29,27", true}, {"29,28", true}, {"29,29", true}, {"29,30", true},
                        {"30,1", true}, {"30,2", true}, {"30,3", true}, {"30,4", true}, {"30,5", true}, {"30,6", true},
                        {"30,7", true}, {"30,8", true}, {"30,9", true}, {"30,10", true}, {"30,11", true},
                        {"30,12", true}, {"30,13", true}, {"30,14", true}, {"30,15", true}, {"30,16", true},
                        {"30,17", true}, {"30,18", true}, {"30,19", true}, {"30,20", true}, {"30,21", true},
                        {"30,22", true}, {"30,23", true}, {"30,24", true}, {"30,25", true}, {"30,26", true},
                        {"30,27", true}, {"30,28", true}, {"30,29", true}, {"30,30", true},
                    });
            }
        }

        #endregion
    }
}