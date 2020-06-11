// Score: 100% 

using System;

class Solution {

    public int solution(int N) {
    
        // Convert N to binary (Base 2)
        string binary = Convert.ToString(N, 2);
        
        // Initialise the variables
        int max_gap = 0;        
        int cur_gap = 0;        
        bool open_one = false;
        
        // Loop the chars within binary string
        for(int i = 0; i < binary.Length; i++) 
        {
        
            // If a '1' was previously identified
            if(open_one) 
            {
            
                // If the current char is '0'
                if(binary[i] == '0') 
                {
                
                    // Increment the gap
                    cur_gap++;
                    
                } else 
                {
                    
                    /* 
                     * The binary gap either never existed, or is now closed
                     * Set the max_gap to the cur_gap if cur_gap
                     * is larger than the previously found max_gap
                     */
                    max_gap = cur_gap > max_gap ? cur_gap : max_gap;
                    cur_gap = 0;
                    
                }
                
            } else {
            
                // Set open_one depending on the current char
                open_one = binary[i] == '1';
                
            }
            
        }
        
        return max_gap;
        
    }
    
}
