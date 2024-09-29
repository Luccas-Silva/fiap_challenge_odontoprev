package com.odontoprev.Java_Challenge.gateways;

import lombok.RequiredArgsConstructor;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/dentista")
@RequiredArgsConstructor
@Validated
public class DentistaController {
}
