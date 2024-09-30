package com.odontoprev.Java_Challenge.gateways.requests;

import lombok.Data;
import lombok.NonNull;

@Data
public class DentistaPatchNomeClinica {
    @NonNull
    private String nomeClinica;
}
