package time;

public class GetDiffer {
	public String getdifference(String date1,String date2) {
		int differ=0;	
		String[] date1info = date1.split(" ");
		String day1=date1info[0];
		String month1 = date1info[1];
		String year1 = date1info[2];
		
		String[] date2info = date2.split(" ");
		String day2=date2info[0];
		String month2 = date2info[1];
		String year2 = date2info[2];
		
		int daynumber1 = this.getdays(day1,month1,year1);
		int daynumber2 = this.getdays(day2,month2,year2);
		differ = daynumber2 - daynumber1;
		String date3;
		
		if(differ<0) {
			date3 = date2;
			date1 = date2;
			date2 = date3;
		}
		return String.join(", ",date1,date2,Integer.toString(Math.abs(differ)));
	}
	
	public int getdays(String day, String month, String year) {
		int days=0;
		// 5 .6 .2019
		boolean lunaryear=false;
		int y = Integer.parseInt(year);
		
		if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0) {
			lunaryear=true;
		}else {
			lunaryear=false;
		}		
		for(int i=1990;i<y;i++) {
			if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0) {
				days+=366;
			}else {
				days+=365;
			}
		}		
		for(int i=1;i<Integer.parseInt(month);i++) {
			switch (i) {
			case 1:
			case 3:
			case 5:
			case 7:
			case 8:
			case 10:
			case 12:
				days+=31;				
				break;
			case 4:
			case 6:
			case 9:
			case 11:
				days+=30;
				break;
			case 2:
				if (lunaryear) {
					days+=29;
				}else {
					days+=28;
				}
			default:
				break;
			}	
		}
		days+=Integer.parseInt(day);
		return days;
	}
}
