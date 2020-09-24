using System;
public class InfCubes {
    public static void Main() {
        string[] shapes = new string[2] {
            "█ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █",
            " █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █"
        };

        while (true) {
            foreach (var i in shapes) {
                Debug.WriteLine(i);
            }
        }
    }
}