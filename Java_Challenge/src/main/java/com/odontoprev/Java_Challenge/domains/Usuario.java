package com.odontoprev.Java_Challenge.domains;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import lombok.*;

import java.util.Date;

@Data
@Builder
@Entity
@NoArgsConstructor
@AllArgsConstructor
@Setter
@Getter
@ToString
public class Usuario {

    @Id
    @GeneratedValue(strategy = GenerationType.UUID)
    private String cpf_cnpj;
    
    private String nome;
    private Date dataNascimento;
    private String Email;
    private String Celular;

}

