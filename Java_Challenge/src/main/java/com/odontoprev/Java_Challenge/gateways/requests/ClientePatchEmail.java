package com.odontoprev.Java_Challenge.gateways.requests;


import lombok.Data;
import lombok.NonNull;
import org.antlr.v4.runtime.misc.NotNull;

@Data
public class ClientePatchEmail {
    @NonNull
    private String Email;
}
