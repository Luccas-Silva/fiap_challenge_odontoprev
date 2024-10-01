package com.odontoprev.Java_Challenge.gateways.requests;

import lombok.Data;
import lombok.NonNull;

import java.util.Date;

@Data
public class ConsultaPatchDateConsulta {
    @NonNull
    private Date dateConsulta;
}
