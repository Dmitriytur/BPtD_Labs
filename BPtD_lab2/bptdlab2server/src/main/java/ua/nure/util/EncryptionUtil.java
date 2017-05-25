package ua.nure.util;


import java.security.KeyPair;
import java.security.KeyPairGenerator;
import java.security.NoSuchAlgorithmException;
import java.security.PrivateKey;
import java.security.PublicKey;
import java.security.spec.AlgorithmParameterSpec;
import java.util.Arrays;
import java.util.Base64;

import javax.crypto.Cipher;

public class EncryptionUtil {

    private static final String ALGORITHM = "RSA";

    private static final int DEFAULT_KEY_SIZE = 1024;


    private PublicKey publicKey;
    private PrivateKey privateKey;


    public EncryptionUtil(){
        generateKey(DEFAULT_KEY_SIZE);
    }

    public EncryptionUtil(int keySize){
        generateKey(DEFAULT_KEY_SIZE);
    }

    public void generateKey(int keySize) {
        try {
            KeyPairGenerator keyGen = KeyPairGenerator.getInstance(ALGORITHM);
            keyGen.initialize(keySize);
            KeyPair key = keyGen.generateKeyPair();

            publicKey = key.getPublic();
            privateKey = key.getPrivate();

        } catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
        }

    }



    public  byte[] encrypt(String text) {
        byte[] cipherText = null;
        try {

            Cipher cipher = Cipher.getInstance(ALGORITHM);
            cipher.init(Cipher.ENCRYPT_MODE,  publicKey);
            cipherText = cipher.doFinal(text.getBytes());

        } catch (Exception e) {
            e.printStackTrace();
        }
        return cipherText;
    }


    public  String decrypt(byte[] text) {
        byte[] decryptedText = null;
        try {

            final Cipher cipher = Cipher.getInstance(ALGORITHM);
            cipher.init(Cipher.DECRYPT_MODE, privateKey);
            decryptedText = cipher.doFinal(text);

        } catch (Exception ex) {
            decryptedText = new byte[2];
            ex.printStackTrace();
        }

        return new String(decryptedText);
    }

    public byte[] getPublicKey() {
        return publicKey.getEncoded();
    }

    public String getKeyFormat(){
        return publicKey.getFormat();
    }


    public static void main(String[] args) {
        String message = "Hello";

        EncryptionUtil encryptionUtil = new EncryptionUtil();

        byte[] cryptogram = encryptionUtil.encrypt(message);
        System.out.println(Base64.getEncoder().encodeToString(cryptogram));
        String decryptedMessage = encryptionUtil.decrypt(cryptogram);
        System.out.println(decryptedMessage);

    }
}

//DatatypeConverter.parseHexBinary(s);