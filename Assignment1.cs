namespace Assignment1
{
    class Assignment1 {
    static void Main (string[]args){
           Console.WriteLine("Please input password :");  
           int password1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Please input agency :");  
           string password2 = (Console.ReadLine());
        
           bool passcheck1_1 = password2 == "CIA";
           bool passcheck1_2 = password2 == "FBI";
           bool passcheck1_3 = password2 == "NSA";
           
           int CIA_1 = password1/100000;
           int CIA_2 = (password1/10000) - (CIA_1 * 10);
           int CIA_3 = (password1/1000) - ((CIA_1 * 100) + (CIA_2 * 10));
           int CIA_4 = (password1/100) - ((CIA_1 * 1000) + (CIA_2 * 100) + (CIA_3 * 10));
           int CIA_5 = (password1/10) - ((CIA_1 * 10000) + (CIA_2 * 1000) + (CIA_3 * 100) + (CIA_4 * 10));
           int CIA_6 = (password1/1) - ((CIA_1 * 100000) + (CIA_2 * 10000) + (CIA_3 * 1000) + (CIA_4 * 100) + (CIA_5 * 10));
           bool CIAcheck_1 = CIA_6 % 3 == 0;
           bool CIAcheck_2 = (CIA_5 % 2 == 0)||(CIA_5 > 6);
           bool CIAcheck_3 = (CIA_3 >=6)&&(CIA_3<8);
           bool CIAcheck_4 = (CIAcheck_1 )&&(CIAcheck_2 )&&(CIAcheck_3);

           int FBI_1 = password1/100000;
           int FBI_2 = (password1/10000) - (FBI_1 * 10);
           int FBI_3 = (password1/1000) - ((FBI_1 * 100) + (FBI_2 * 10));
           int FBI_4 = (password1/100) - ((FBI_1 * 1000) + (FBI_2 * 100) + (FBI_3 * 10));
           bool FBIcheck_1 = (FBI_1 >=4)&&(FBI_1<=7);
           bool FBIcheck_2 = ((FBI_2 +1)%2)==0;
           bool FBIcheck_3 = (FBI_4%2)==0 &&(FBI_4!=6);
           bool FBIcheck_4 = (FBIcheck_1 )&&(FBIcheck_2 )&&(FBIcheck_3);

           int NSA_1 = password1/100000;
           int NSA_2 = (password1/10000) - (NSA_1 * 10);
           int NSA_3 = (password1/1000) - ((NSA_1 * 100) + (NSA_2 * 10));
           int NSA_4 = (password1/100) - ((NSA_1 * 1000) + (NSA_2 * 100) + (NSA_3 * 10));
           int NSA_5 = (password1/10) - ((NSA_1 * 10000) + (NSA_2 * 1000) + (NSA_3 * 100) + (NSA_4 * 10));
           int NSA_6 = (password1/1) - ((NSA_1 * 100000) + (NSA_2 * 10000) + (NSA_3 * 1000) + (NSA_4 * 100) + (NSA_5 * 10));
           bool NSAcheck_1 = ((NSA_4 % 3)==0)&&((NSA_4 % 2)!=0);
           bool NSAcheck_2 = (30%NSA_6)==0;
           bool NSAcheck_3 = (NSAcheck_1 )&&(NSAcheck_2 );

            if(password2 == "CIA"){

                if((password1 <=999999) && (password1 >99999)){

                    password1=password1-(CIA_1*100000);               
                    password1=password1-(CIA_2*10000);                                  
                    password1=password1-(CIA_3*1000);              
                    password1=password1-(CIA_4*100);              
                    password1=password1-(CIA_5*10);              
                    password1=password1-(CIA_6*1);              
                        if((CIAcheck_1 )&&(CIAcheck_2 )&&(CIAcheck_3))
                        {Console.WriteLine("Password = {0}",CIAcheck_4);   }
                        else{Console.WriteLine("Password = {0}",CIAcheck_4);}
                }else{ Console.WriteLine("Password = False");}  

              } else{
                if(password2 == "FBI"){

                    if((password1 <=999999) && (password1 >=99999)){

                      password1=password1-(FBI_1*100000);                                                                   
                      password1=password1-(FBI_2*10000);                                                                     
                      password1=password1-(FBI_3*1000);                                       
                      password1=password1-(FBI_4*100);                                                                  
                           if((FBIcheck_1 )&&(FBIcheck_2 )&&(FBIcheck_3))
                             {Console.WriteLine("Password = {0}",FBIcheck_4);}
                             else{ Console.WriteLine("Password = {0}",FBIcheck_4);}

                    }else{Console.WriteLine("Password = False");}     
                
                }else{if(password2 == "NSA"){

                          if((password1 <=999999) && (password1 >=99999))
                          
                            {if( (NSA_1==7)||(NSA_2==7)||(NSA_3==7)||(NSA_4==7)||(NSA_5==7)||(NSA_6==7))
                               {  
                                  password1=password1-(NSA_1*100000);                                                   
                                    password1=password1-(NSA_2*10000);                                                  
                                    password1=password1-(NSA_3*1000);                                                                                          
                                    password1=password1-(NSA_4*100);                                                                                 
                                    password1=password1-(NSA_5*10);              
                                    password1=password1-(NSA_6*1);                                                        
                                            if((NSAcheck_1 )&&(NSAcheck_2 ))
                                              {Console.WriteLine("Password = {0}",FBIcheck_4);}
                                          else{ Console.WriteLine("Password = {0}",FBIcheck_4);}
                                      
                                }else {Console.WriteLine("Password = False");}
                    
                            }else{Console.WriteLine("Password = False");}              
                        } 
                        else{ Console.WriteLine("Password = False");}
                }
              }         
        }
    }
}
