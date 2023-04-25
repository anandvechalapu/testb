package com.sacral.BBP-11.service;

import com.sacral.BBP-11.model.Login;
import com.sacral.BBP-11.repository.LoginRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class LoginService {

    @Autowired
    private LoginRepository loginRepository;

    public List<Login> findByMobileNo(String mobileNo) {
        return loginRepository.findByMobileNo(mobileNo);
    }

    public Boolean existsByMobileNoAndOtp(String mobileNo, int otp) {
        return loginRepository.existsByMobileNoAndOtp(mobileNo, otp);
    }
}