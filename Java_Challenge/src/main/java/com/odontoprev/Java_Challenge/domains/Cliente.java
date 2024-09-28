package com.odontoprev.Java_Challenge.domains;

import jakarta.persistence.Entity;
import lombok.*;

@Data
@Builder
@Entity
@NoArgsConstructor
@AllArgsConstructor
@Setter
@Getter
@ToString
public class Cliente extends Usuario{

    private String cep;
    private String tipoPlano;


}
