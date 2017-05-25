package ua.nure.web;

import org.springframework.web.bind.annotation.*;
import ua.nure.util.EncryptionUtil;

import java.util.Base64;

@RestController
public class SecurityController {

    private EncryptionUtil encryptionUtil = new EncryptionUtil(1024);

    @RequestMapping(value = "/getData", method = RequestMethod.POST)
    public void getData(@RequestBody byte[] message){
        byte[] encryptedMessage =  message;
        String decryptedMessage = encryptionUtil.decrypt(encryptedMessage);
        System.out.println(decryptedMessage);
    }

    @RequestMapping(value = "/key", method = RequestMethod.GET)
    public String getPublicKey(){
        return Base64.getEncoder().encodeToString(encryptionUtil.getPublicKey());
    }

    @RequestMapping(value = "/generateKeys/{keySize}", method = RequestMethod.GET)
    public void generateKeys(@PathVariable("keySize") int keySize){
        encryptionUtil.generateKey(keySize);
    }
}
