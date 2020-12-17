import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { HeroService } from '../hero.service';
import { Hero } from '../hero';

@Component({
  selector: 'app-hero-detail',
  templateUrl: './hero-detail.component.html',
  styleUrls: ['./hero-detail.component.scss']
})
export class HeroDetailComponent implements OnInit {
  @Input() hero: Hero;

  constructor(
    private route: ActivatedRoute,
    private heroService: HeroService,
    private location: Location
  ) {

    this.hero = {id: 0, name:"Placeholder"};
  }

  ngOnInit(): void {
    this.getHero();
  }

  getHero(): void {
    if(this !== null){

      const id = <number | null> this.route.snapshot.paramMap.get('id');

      if(id !== null){
        this.heroService.getHero( id )
        .subscribe(hero => this.hero = hero);
      }
      
    }  
  }

  save(): void {
    this.heroService.updateHero(this.hero)
      .subscribe(() => this.goBack());
  }

  goBack(): void {
    this.location.back();
  }
}
