package com.sacral.BBP-11.controller;

import com.sacral.BBP-11.model.Login;
import com.sacral.BBP-11.service.LoginService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
public class LoginController {

    @Autowired
    private LoginService loginService;

    @GetMapping("/users/{mobileNo}")
    public List<Login> getByMobileNo(@PathVariable("mobileNo") String mobileNo) {
        return loginService.findByMobileNo(mobileNo);
    }

    @GetMapping("/users/otp/{mobileNo}/{otp}")
    public Boolean existsByMobileNoAndOtp(@PathVariable("mobileNo") String mobileNo,
                                         @PathVariable("otp") int otp) {
        return loginService.existsByMobileNoAndOtp(mobileNo, otp);
    }

}