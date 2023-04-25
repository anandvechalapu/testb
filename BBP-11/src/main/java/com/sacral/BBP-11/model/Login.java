package com.sacral.BBP-11.model;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Login {
    
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;
    private String mobileNo;
    private int otp;
    
    public Login() {
        //default constructor
    }
    
    public Login(String mobileNo, int otp) {
        this.mobileNo = mobileNo;
        this.otp = otp;
    }
    
    public Long getId() {
        return id;
    }
    
    public void setId(Long id) {
        this.id = id;
    }
    
    public String getMobileNo() {
        return mobileNo;
    }
    
    public void setMobileNo(String mobileNo) {
        this.mobileNo = mobileNo;
    }
    
    public int getOtp() {
        return otp;
    }
    
    public void setOtp(int otp) {
        this.otp = otp;
    }
}