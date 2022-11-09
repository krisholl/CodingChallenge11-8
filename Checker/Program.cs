using Checker.Verification;

Interview you = new Interview();
int[] Questions = { 5, 6, 10, 10, 15, 15, 20, 20 }; // Adjust this for individual question time
int TotalTime = 120; // Adjust this for total time for test
Console.WriteLine(you.IsVerified(Questions, TotalTime)? "Qualified": "DisQualified");