using GradeAverageCalculator;

var sophia = new Student("Sophia");
sophia.AddTestResult(93);
sophia.AddTestResult(87);
sophia.AddTestResult(98);
sophia.AddTestResult(95);
sophia.AddTestResult(100);

var nicolas = new Student("Nicolas");
nicolas.AddTestResult(80);
nicolas.AddTestResult(83);
nicolas.AddTestResult(82);
nicolas.AddTestResult(88);
nicolas.AddTestResult(85);

var zahirah = new Student("Zahirah");
zahirah.AddTestResult(84);
zahirah.AddTestResult(96);
zahirah.AddTestResult(73);
zahirah.AddTestResult(85);
zahirah.AddTestResult(79);

var jeong = new Student("Jeong");
jeong.AddTestResult(90);
jeong.AddTestResult(92);
jeong.AddTestResult(98);
jeong.AddTestResult(100);
jeong.AddTestResult(97);

Console.WriteLine($"{sophia.Name}: { sophia.GetAverageScore()}");
Console.WriteLine($"{nicolas.Name}: {nicolas.GetAverageScore()}");
Console.WriteLine($"{zahirah.Name}: {zahirah.GetAverageScore()}");
Console.WriteLine($"{jeong.Name}: {jeong.GetAverageScore()}");
