import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class TransportPrice {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int kilometers = Integer.parseInt(reader.readLine());
        String dayOrNight = reader.readLine();
        double price = 0.0d;

        if(kilometers < 20){
            switch (dayOrNight){
                case "day":
                    price += 0.70 + (kilometers * 0.79);
                    break;
                case "night":
                    price += 0.70 + (kilometers * 0.90);
                    break;

            }
        }else if(kilometers >= 20 && kilometers < 100){
            if(dayOrNight.equals("day") || dayOrNight.equals("night")){
                price += kilometers * 0.09;
            }
        }else {
            price += kilometers * 0.06;
        }

        System.out.printf("%.2f%n",price);
    }
}
