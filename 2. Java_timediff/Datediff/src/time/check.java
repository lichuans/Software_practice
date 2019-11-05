package time;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.text.ParseException;

public class check {
	public static void main(String[] args) throws ParseException {
		Scanner myObj = new Scanner(System.in);  // Create a Scanner object
		System.out.println("Enter date");
		String input = myObj.nextLine();
		String pattern = "\\d{1,2} \\d{1,2} (\\d{4}),\\s?\\d{1,2} \\d{1,2} (\\d{4})";		
		GetDiffer getDiffer = new GetDiffer();
		boolean isMatch = Pattern.matches(pattern, input);
		boolean isYearMatch = false;
		int y1=0,y2=0;     
		while(!isMatch || !isYearMatch){
			 if(!isMatch) {
				 System.out.println("Wrong, please enter as \"DD MM YYYY, DD MM YYYY\", like 01 01 1992, 12 12 2008"); 
			 }else if(!isYearMatch){
				 System.out.println("Wrong, an input range of dates from 1900 to 2010");				 
			 }
			 System.out.println("Enter date");
			 input = myObj.nextLine();   		 
	   	     Pattern r = Pattern.compile(pattern);
	   	     Matcher m = r.matcher(input);
	   	      
	   	     if(m.find()) {
	   	    	  isMatch = true;
	   	    	  y1 =  Integer.parseInt(m.group(1)) ;
	   	    	  y2 =  Integer.parseInt(m.group(2)) ;
	   	    	  
	   	    	  if(y1>2010||y1<1900||y2>2010||y2<1900) {
	   		    	 isYearMatch = false;	 
	   		     } else {
	   		    	 isYearMatch = true;
	   		     }
	   	      }else {
	   	    	  isMatch = false;
	   	      }    
    	 }	
		String date1 = input.split(",\\s?")[0];
		String date2 = input.split(",\\s?")[1];		
		String results = getDiffer.getdifference(date1,date2);
		System.out.println(results);		
	}
	
} 