import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Greeting {

    public static void main(String[] args) throws IOException {

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String firstName = reader.readLine();
        String secondName = reader.readLine();

        if(firstName != null && firstName.isEmpty()) {
            firstName = "*****";
        }
        if(secondName != null && secondName.isEmpty()){
            secondName = "*****";
        }

         System.out.printf("Hello, %s %s!%n",firstName, secondName);
    }
}
