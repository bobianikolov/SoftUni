import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class SimpleTextEditor {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(reader.readLine());
        ArrayDeque<String> textEditor = new ArrayDeque<>();
        String text = "";
        textEditor.push(text);

        for (int i = 1; i <= n; i++) {
            String[] inputData = reader.readLine().split("\\s+");
            String command = inputData[0];

            switch (command){
                case "1":
                    String str = inputData[1];
                    text += str;
                    textEditor.push(text);
                    break;
                case "2":
                    int count = Integer.parseInt(inputData[1]);
                    text = text.substring(0,text.length() - count);
                    textEditor.push(text);
                    break;
                case "3":
                    int index = Integer.parseInt(inputData[1]);
                    System.out.println(text.charAt(index - 1));
                    break;
                case "4":
                    textEditor.pop();
                    text = textEditor.peek();
                    break;
            }
        }
    }
}
