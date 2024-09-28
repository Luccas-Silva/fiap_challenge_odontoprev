package com.odontoprev.Java_Challenge.domains;


import jakarta.persistence.*;
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
public class Consulta {

    @Id
    @GeneratedValue(strategy = GenerationType.UUID)
    private String idConsulta;

    private Date dateConsulta;
    private String tipoConsulta;
    private Double valorMedioConsulta;

    @OneToOne(cascade = CascadeType.ALL)
    Dentista dentista;

    @OneToOne(cascade = CascadeType.ALL)
    Cliente cliente;
}
