import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;

public class Robotics {
    private static final int TO_WORK = 0;

    private String name;
    private long processTime;
    private long timeToWork;

    private Robotics(String name, long processTime){
        this.name = name;
        this.processTime = processTime;
        this.timeToWork = TO_WORK;
    }

    public void processingTime(long time){
        this.timeToWork = time + this.processTime;
    }

    public boolean isFree(long time){
        if(time >= this.timeToWork){
            return true;
        }
        return false;
    }

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] input = reader.readLine().split("[-;]+");
        ArrayDeque<Robotics> robots = new ArrayDeque<>();
        ArrayDeque<String> products = new ArrayDeque<>();

        for (int i = 0; i < input.length; i+=2) {
            robots.offer(new Robotics(input[i],Integer.parseInt(input[i+1])));
        }

        String[] time = reader.readLine().split(":");
        long hour = Integer.parseInt(time[0]) * 60 * 60;
        long minutes = Integer.parseInt(time[1]) * 60;
        long seconds = Integer.parseInt(time[2]);
        long allSeconds = hour + minutes + seconds;


        String command = "";
        while (!"End".equals(command = reader.readLine())){
            products.offer(command);
        }

        while (!products.isEmpty()){
            boolean productOffer = false;
            String currentProduct = products.poll();
            allSeconds++;

            for (int i = 0; i < robots.size(); i++) {
                Robotics currentRobot = robots.poll();
                if(currentRobot.isFree(allSeconds)){
                    currentRobot.processingTime(allSeconds);
                    System.out.printf("%s - %s [%s]%n",currentRobot.name,currentProduct,ConvertSecondsToMinutes(allSeconds));
                    robots.offer(currentRobot);
                    productOffer = true;
                    break;
                }
                robots.offer(currentRobot);
            }
            if(!productOffer){
                products.offer(currentProduct);
            }
        }
    }

    private static String ConvertSecondsToMinutes(long allSeconds) {
        long hours = allSeconds / 3600;
        long minutes = (allSeconds - (hours * 3600)) / 60;
        long seconds = (allSeconds - (hours * 3600)) - minutes * 60;
        if(hours > 23){
            hours = 0;
        }

        return String.format("%02d:%02d:%02d",hours,minutes,seconds);
    }
}


