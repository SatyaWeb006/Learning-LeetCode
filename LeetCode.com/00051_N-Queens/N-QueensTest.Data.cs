using NUnit.Framework;

namespace LeetCode.com._00051_N_Queens
{
    [TestFixture]
    public partial class SolveNQueensTest
    {
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

        #region 棋盤繪製驗證

        static IEnumerable<TestCaseData> CreateCheckerBoard
        {
            get
            {
                yield return
                    new TestCaseData(4, new Dictionary<string, bool>()
                    {
                        {"1A", true},
                        {"1B", true},
                        {"1C", true},
                        {"1D", true},
                    });

                yield return
                    new TestCaseData(30, new Dictionary<string, bool>()
                    {
                        {"A1", true}, {"B1", true}, {"C1", true}, {"D1", true}, {"E1", true}, {"F1", true},
                        {"G1", true}, {"H1", true}, {"I1", true}, {"J1", true}, {"K1", true}, {"L1", true},
                        {"M1", true}, {"N1", true}, {"O1", true}, {"P1", true}, {"Q1", true}, {"R1", true},
                        {"S1", true}, {"T1", true}, {"U1", true}, {"V1", true}, {"W1", true}, {"X1", true},
                        {"Y1", true}, {"Z1", true}, {"AA1", true}, {"AB1", true}, {"AC1", true}, {"AD1", true},
                        {"AE1", true}, {"AF1", true}, {"A2", true}, {"B2", true}, {"C2", true}, {"D2", true},
                        {"E2", true}, {"F2", true},
                        {"G2", true}, {"H2", true}, {"I2", true}, {"J2", true}, {"K2", true}, {"L2", true},
                        {"M2", true}, {"N2", true}, {"O2", true}, {"P2", true}, {"Q2", true}, {"R2", true},
                        {"S2", true}, {"T2", true}, {"U2", true}, {"V2", true}, {"W2", true}, {"X2", true},
                        {"Y2", true}, {"Z2", true}, {"AA2", true}, {"AB2", true}, {"AC2", true}, {"AD2", true},
                        {"AE2", true}, {"AF2", true}, {"A3", true}, {"B3", true}, {"C3", true}, {"D3", true},
                        {"E3", true}, {"F3", true},
                        {"G3", true}, {"H3", true}, {"I3", true}, {"J3", true}, {"K3", true}, {"L3", true},
                        {"M3", true}, {"N3", true}, {"O3", true}, {"P3", true}, {"Q3", true}, {"R3", true},
                        {"S3", true}, {"T3", true}, {"U3", true}, {"V3", true}, {"W3", true}, {"X3", true},
                        {"Y3", true}, {"Z3", true}, {"AA3", true}, {"AB3", true}, {"AC3", true}, {"AD3", true},
                        {"AE3", true}, {"AF3", true}, {"A4", true}, {"B4", true}, {"C4", true}, {"D4", true},
                        {"E4", true}, {"F4", true},
                        {"G4", true}, {"H4", true}, {"I4", true}, {"J4", true}, {"K4", true}, {"L4", true},
                        {"M4", true}, {"N4", true}, {"O4", true}, {"P4", true}, {"Q4", true}, {"R4", true},
                        {"S4", true}, {"T4", true}, {"U4", true}, {"V4", true}, {"W4", true}, {"X4", true},
                        {"Y4", true}, {"Z4", true}, {"AA4", true}, {"AB4", true}, {"AC4", true}, {"AD4", true},
                        {"AE4", true}, {"AF4", true}, {"A5", true}, {"B5", true}, {"C5", true}, {"D5", true},
                        {"E5", true}, {"F5", true},
                        {"G5", true}, {"H5", true}, {"I5", true}, {"J5", true}, {"K5", true}, {"L5", true},
                        {"M5", true}, {"N5", true}, {"O5", true}, {"P5", true}, {"Q5", true}, {"R5", true},
                        {"S5", true}, {"T5", true}, {"U5", true}, {"V5", true}, {"W5", true}, {"X5", true},
                        {"Y5", true}, {"Z5", true}, {"AA5", true}, {"AB5", true}, {"AC5", true}, {"AD5", true},
                        {"AE5", true}, {"AF5", true}, {"A6", true}, {"B6", true}, {"C6", true}, {"D6", true},
                        {"E6", true}, {"F6", true},
                        {"G6", true}, {"H6", true}, {"I6", true}, {"J6", true}, {"K6", true}, {"L6", true},
                        {"M6", true}, {"N6", true}, {"O6", true}, {"P6", true}, {"Q6", true}, {"R6", true},
                        {"S6", true}, {"T6", true}, {"U6", true}, {"V6", true}, {"W6", true}, {"X6", true},
                        {"Y6", true}, {"Z6", true}, {"AA6", true}, {"AB6", true}, {"AC6", true}, {"AD6", true},
                        {"AE6", true}, {"AF6", true}, {"A7", true}, {"B7", true}, {"C7", true}, {"D7", true},
                        {"E7", true}, {"F7", true},
                        {"G7", true}, {"H7", true}, {"I7", true}, {"J7", true}, {"K7", true}, {"L7", true},
                        {"M7", true}, {"N7", true}, {"O7", true}, {"P7", true}, {"Q7", true}, {"R7", true},
                        {"S7", true}, {"T7", true}, {"U7", true}, {"V7", true}, {"W7", true}, {"X7", true},
                        {"Y7", true}, {"Z7", true}, {"AA7", true}, {"AB7", true}, {"AC7", true}, {"AD7", true},
                        {"AE7", true}, {"AF7", true}, {"A8", true}, {"B8", true}, {"C8", true}, {"D8", true},
                        {"E8", true}, {"F8", true},
                        {"G8", true}, {"H8", true}, {"I8", true}, {"J8", true}, {"K8", true}, {"L8", true},
                        {"M8", true}, {"N8", true}, {"O8", true}, {"P8", true}, {"Q8", true}, {"R8", true},
                        {"S8", true}, {"T8", true}, {"U8", true}, {"V8", true}, {"W8", true}, {"X8", true},
                        {"Y8", true}, {"Z8", true}, {"AA8", true}, {"AB8", true}, {"AC8", true}, {"AD8", true},
                        {"AE8", true}, {"AF8", true}, {"A9", true}, {"B9", true}, {"C9", true}, {"D9", true},
                        {"E9", true}, {"F9", true},
                        {"G9", true}, {"H9", true}, {"I9", true}, {"J9", true}, {"K9", true}, {"L9", true},
                        {"M9", true}, {"N9", true}, {"O9", true}, {"P9", true}, {"Q9", true}, {"R9", true},
                        {"S9", true}, {"T9", true}, {"U9", true}, {"V9", true}, {"W9", true}, {"X9", true},
                        {"Y9", true}, {"Z9", true}, {"AA9", true}, {"AB9", true}, {"AC9", true}, {"AD9", true},
                        {"AE9", true}, {"AF9", true}, {"A10", true}, {"B10", true}, {"C10", true}, {"D10", true},
                        {"E10", true}, {"F10", true},
                        {"G10", true}, {"H10", true}, {"I10", true}, {"J10", true}, {"K10", true}, {"L10", true},
                        {"M10", true}, {"N10", true}, {"O10", true}, {"P10", true}, {"Q10", true}, {"R10", true},
                        {"S10", true}, {"T10", true}, {"U10", true}, {"V10", true}, {"W10", true}, {"X10", true},
                        {"Y10", true}, {"Z10", true}, {"AA10", true}, {"AB10", true}, {"AC10", true}, {"AD10", true},
                        {"AE10", true}, {"AF10", true}, {"A11", true}, {"B11", true}, {"C11", true}, {"D11", true},
                        {"E11", true}, {"F11", true},
                        {"G11", true}, {"H11", true}, {"I11", true}, {"J11", true}, {"K11", true}, {"L11", true},
                        {"M11", true}, {"N11", true}, {"O11", true}, {"P11", true}, {"Q11", true}, {"R11", true},
                        {"S11", true}, {"T11", true}, {"U11", true}, {"V11", true}, {"W11", true}, {"X11", true},
                        {"Y11", true}, {"Z11", true}, {"AA11", true}, {"AB11", true}, {"AC11", true}, {"AD11", true},
                        {"AE11", true}, {"AF11", true}, {"A12", true}, {"B12", true}, {"C12", true}, {"D12", true},
                        {"E12", true}, {"F12", true},
                        {"G12", true}, {"H12", true}, {"I12", true}, {"J12", true}, {"K12", true}, {"L12", true},
                        {"M12", true}, {"N12", true}, {"O12", true}, {"P12", true}, {"Q12", true}, {"R12", true},
                        {"S12", true}, {"T12", true}, {"U12", true}, {"V12", true}, {"W12", true}, {"X12", true},
                        {"Y12", true}, {"Z12", true}, {"AA12", true}, {"AB12", true}, {"AC12", true}, {"AD12", true},
                        {"AE12", true}, {"AF12", true}, {"A13", true}, {"B13", true}, {"C13", true}, {"D13", true},
                        {"E13", true}, {"F13", true},
                        {"G13", true}, {"H13", true}, {"I13", true}, {"J13", true}, {"K13", true}, {"L13", true},
                        {"M13", true}, {"N13", true}, {"O13", true}, {"P13", true}, {"Q13", true}, {"R13", true},
                        {"S13", true}, {"T13", true}, {"U13", true}, {"V13", true}, {"W13", true}, {"X13", true},
                        {"Y13", true}, {"Z13", true}, {"AA13", true}, {"AB13", true}, {"AC13", true}, {"AD13", true},
                        {"AE13", true}, {"AF13", true}, {"A14", true}, {"B14", true}, {"C14", true}, {"D14", true},
                        {"E14", true}, {"F14", true},
                        {"G14", true}, {"H14", true}, {"I14", true}, {"J14", true}, {"K14", true}, {"L14", true},
                        {"M14", true}, {"N14", true}, {"O14", true}, {"P14", true}, {"Q14", true}, {"R14", true},
                        {"S14", true}, {"T14", true}, {"U14", true}, {"V14", true}, {"W14", true}, {"X14", true},
                        {"Y14", true}, {"Z14", true}, {"AA14", true}, {"AB14", true}, {"AC14", true}, {"AD14", true},
                        {"AE14", true}, {"AF14", true}, {"A15", true}, {"B15", true}, {"C15", true}, {"D15", true},
                        {"E15", true}, {"F15", true},
                        {"G15", true}, {"H15", true}, {"I15", true}, {"J15", true}, {"K15", true}, {"L15", true},
                        {"M15", true}, {"N15", true}, {"O15", true}, {"P15", true}, {"Q15", true}, {"R15", true},
                        {"S15", true}, {"T15", true}, {"U15", true}, {"V15", true}, {"W15", true}, {"X15", true},
                        {"Y15", true}, {"Z15", true}, {"AA15", true}, {"AB15", true}, {"AC15", true}, {"AD15", true},
                        {"AE15", true}, {"AF15", true},
                        {"A16", true}, {"B16", true}, {"C16", true}, {"D16", true}, {"E16", true}, {"F16", true},
                        {"G16", true}, {"H16", true}, {"I16", true}, {"J16", true}, {"K16", true}, {"L16", true},
                        {"M16", true}, {"N16", true}, {"O16", true}, {"P16", true}, {"Q16", true}, {"R16", true},
                        {"S16", true}, {"T16", true}, {"U16", true}, {"V16", true}, {"W16", true}, {"X16", true},
                        {"Y16", true}, {"Z16", true}, {"AA16", true}, {"AB16", true}, {"AC16", true}, {"AD16", true},
                        {"AE16", true}, {"AF16", true},
                        {"A17", true}, {"B17", true}, {"C17", true}, {"D17", true}, {"E17", true}, {"F17", true},
                        {"G17", true}, {"H17", true}, {"I17", true}, {"J17", true}, {"K17", true}, {"L17", true},
                        {"M17", true}, {"N17", true}, {"O17", true}, {"P17", true}, {"Q17", true}, {"R17", true},
                        {"S17", true}, {"T17", true}, {"U17", true}, {"V17", true}, {"W17", true}, {"X17", true},
                        {"Y17", true}, {"Z17", true}, {"AA17", true}, {"AB17", true}, {"AC17", true}, {"AD17", true},
                        {"AE17", true}, {"AF17", true},
                        {"A18", true}, {"B18", true}, {"C18", true}, {"D18", true}, {"E18", true}, {"F18", true},
                        {"G18", true}, {"H18", true}, {"I18", true}, {"J18", true}, {"K18", true}, {"L18", true},
                        {"M18", true}, {"N18", true}, {"O18", true}, {"P18", true}, {"Q18", true}, {"R18", true},
                        {"S18", true}, {"T18", true}, {"U18", true}, {"V18", true}, {"W18", true}, {"X18", true},
                        {"Y18", true}, {"Z18", true}, {"AA18", true}, {"AB18", true}, {"AC18", true}, {"AD18", true},
                        {"AE18", true}, {"AF18", true},
                        {"A19", true}, {"B19", true}, {"C19", true}, {"D19", true}, {"E19", true}, {"F19", true},
                        {"G19", true}, {"H19", true}, {"I19", true}, {"J19", true}, {"K19", true}, {"L19", true},
                        {"M19", true}, {"N19", true}, {"O19", true}, {"P19", true}, {"Q19", true}, {"R19", true},
                        {"S19", true}, {"T19", true}, {"U19", true}, {"V19", true}, {"W19", true}, {"X19", true},
                        {"Y19", true}, {"Z19", true}, {"AA19", true}, {"AB19", true}, {"AC19", true}, {"AD19", true},
                        {"AE19", true}, {"AF19", true},
                        {"A20", true}, {"B20", true}, {"C20", true}, {"D20", true}, {"E20", true}, {"F20", true},
                        {"G20", true}, {"H20", true}, {"I20", true}, {"J20", true}, {"K20", true}, {"L20", true},
                        {"M20", true}, {"N20", true}, {"O20", true}, {"P20", true}, {"Q20", true}, {"R20", true},
                        {"S20", true}, {"T20", true}, {"U20", true}, {"V20", true}, {"W20", true}, {"X20", true},
                        {"Y20", true}, {"Z20", true}, {"AA20", true}, {"AB20", true}, {"AC20", true}, {"AD20", true},
                        {"AE20", true}, {"AF20", true},
                        {"A21", true}, {"B21", true}, {"C21", true}, {"D21", true}, {"E21", true}, {"F21", true},
                        {"G21", true}, {"H21", true}, {"I21", true}, {"J21", true}, {"K21", true}, {"L21", true},
                        {"M21", true}, {"N21", true}, {"O21", true}, {"P21", true}, {"Q21", true}, {"R21", true},
                        {"S21", true}, {"T21", true}, {"U21", true}, {"V21", true}, {"W21", true}, {"X21", true},
                        {"Y21", true}, {"Z21", true}, {"AA21", true}, {"AB21", true}, {"AC21", true}, {"AD21", true},
                        {"AE21", true}, {"AF21", true},
                        {"A22", true}, {"B22", true}, {"C22", true}, {"D22", true}, {"E22", true}, {"F22", true},
                        {"G22", true}, {"H22", true}, {"I22", true}, {"J22", true}, {"K22", true}, {"L22", true},
                        {"M22", true}, {"N22", true}, {"O22", true}, {"P22", true}, {"Q22", true}, {"R22", true},
                        {"S22", true}, {"T22", true}, {"U22", true}, {"V22", true}, {"W22", true}, {"X22", true},
                        {"Y22", true}, {"Z22", true}, {"AA22", true}, {"AB22", true}, {"AC22", true}, {"AD22", true},
                        {"AE22", true}, {"AF22", true},
                        {"A23", true}, {"B23", true}, {"C23", true}, {"D23", true}, {"E23", true}, {"F23", true},
                        {"G23", true}, {"H23", true}, {"I23", true}, {"J23", true}, {"K23", true}, {"L23", true},
                        {"M23", true}, {"N23", true}, {"O23", true}, {"P23", true}, {"Q23", true}, {"R23", true},
                        {"S23", true}, {"T23", true}, {"U23", true}, {"V23", true}, {"W23", true}, {"X23", true},
                        {"Y23", true}, {"Z23", true}, {"AA23", true}, {"AB23", true}, {"AC23", true}, {"AD23", true},
                        {"AE23", true}, {"AF23", true},
                        {"A24", true}, {"B24", true}, {"C24", true}, {"D24", true}, {"E24", true}, {"F24", true},
                        {"G24", true}, {"H24", true}, {"I24", true}, {"J24", true}, {"K24", true}, {"L24", true},
                        {"M24", true}, {"N24", true}, {"O24", true}, {"P24", true}, {"Q24", true}, {"R24", true},
                        {"S24", true}, {"T24", true}, {"U24", true}, {"V24", true}, {"W24", true}, {"X24", true},
                        {"Y24", true}, {"Z24", true}, {"AA24", true}, {"AB24", true}, {"AC24", true}, {"AD24", true},
                        {"AE24", true}, {"AF24", true},
                        {"A25", true}, {"B25", true}, {"C25", true}, {"D25", true}, {"E25", true}, {"F25", true},
                        {"G25", true}, {"H25", true}, {"I25", true}, {"J25", true}, {"K25", true}, {"L25", true},
                        {"M25", true}, {"N25", true}, {"O25", true}, {"P25", true}, {"Q25", true}, {"R25", true},
                        {"S25", true}, {"T25", true}, {"U25", true}, {"V25", true}, {"W25", true}, {"X25", true},
                        {"Y25", true}, {"Z25", true}, {"AA25", true}, {"AB25", true}, {"AC25", true}, {"AD25", true},
                        {"AE25", true}, {"AF25", true},
                        {"A26", true}, {"B26", true}, {"C26", true}, {"D26", true}, {"E26", true}, {"F26", true},
                        {"G26", true}, {"H26", true}, {"I26", true}, {"J26", true}, {"K26", true}, {"L26", true},
                        {"M26", true}, {"N26", true}, {"O26", true}, {"P26", true}, {"Q26", true}, {"R26", true},
                        {"S26", true}, {"T26", true}, {"U26", true}, {"V26", true}, {"W26", true}, {"X26", true},
                        {"Y26", true}, {"Z26", true}, {"AA26", true}, {"AB26", true}, {"AC26", true}, {"AD26", true},
                        {"AE26", true}, {"AF26", true},
                        {"A27", true}, {"B27", true}, {"C27", true}, {"D27", true}, {"E27", true}, {"F27", true},
                        {"G27", true}, {"H27", true}, {"I27", true}, {"J27", true}, {"K27", true}, {"L27", true},
                        {"M27", true}, {"N27", true}, {"O27", true}, {"P27", true}, {"Q27", true}, {"R27", true},
                        {"S27", true}, {"T27", true}, {"U27", true}, {"V27", true}, {"W27", true}, {"X27", true},
                        {"Y27", true}, {"Z27", true}, {"AA27", true}, {"AB27", true}, {"AC27", true}, {"AD27", true},
                        {"AE27", true}, {"AF27", true},
                        {"A28", true}, {"B28", true}, {"C28", true}, {"D28", true}, {"E28", true}, {"F28", true},
                        {"G28", true}, {"H28", true}, {"I28", true}, {"J28", true}, {"K28", true}, {"L28", true},
                        {"M28", true}, {"N28", true}, {"O28", true}, {"P28", true}, {"Q28", true}, {"R28", true},
                        {"S28", true}, {"T28", true}, {"U28", true}, {"V28", true}, {"W28", true}, {"X28", true},
                        {"Y28", true}, {"Z28", true}, {"AA28", true}, {"AB28", true}, {"AC28", true}, {"AD28", true},
                        {"AE28", true}, {"AF28", true},
                        {"A29", true}, {"B29", true}, {"C29", true}, {"D29", true}, {"E29", true}, {"F29", true},
                        {"G29", true}, {"H29", true}, {"I29", true}, {"J29", true}, {"K29", true}, {"L29", true},
                        {"M29", true}, {"N29", true}, {"O29", true}, {"P29", true}, {"Q29", true}, {"R29", true},
                        {"S29", true}, {"T29", true}, {"U29", true}, {"V29", true}, {"W29", true}, {"X29", true},
                        {"Y29", true}, {"Z29", true}, {"AA29", true}, {"AB29", true}, {"AC29", true}, {"AD29", true},
                        {"AE29", true}, {"AF29", true},
                        {"A30", true}, {"B30", true}, {"C30", true}, {"D30", true}, {"E30", true}, {"F30", true},
                        {"G30", true}, {"H30", true}, {"I30", true}, {"J30", true}, {"K30", true}, {"L30", true},
                        {"M30", true}, {"N30", true}, {"O30", true}, {"P30", true}, {"Q30", true}, {"R30", true},
                        {"S30", true}, {"T30", true}, {"U30", true}, {"V30", true}, {"W30", true}, {"X30", true},
                        {"Y30", true}, {"Z30", true}, {"AA30", true}, {"AB30", true}, {"AC30", true}, {"AD30", true},
                        {"AE30", true}, {"AF30", true},
                    });
            }
        }

        #endregion
    }
}