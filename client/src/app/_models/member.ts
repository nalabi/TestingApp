import { Photo } from './photo';

export interface Member {
    result: Member[];
    pagination: import("c:/Users/BongumusaN/MyTestingApp/client/src/app/_models/pagination").Pagination;
    id: number;
    username: string;
    photoUrl: string;
    age: number;
    knownAs: string;
    created: Date;
    lastActive: Date;
    gender: string;
    introduction: string;
    lookingFor: string;
    interests: string;
    city: string;
    country: string;
    photos: Photo[];
  }